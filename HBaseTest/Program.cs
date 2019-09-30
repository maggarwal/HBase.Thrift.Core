using Hbase.Thrift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Protocols;
using Thrift.Transports;
using Thrift.Transports.Client;

namespace HBaseTest
{
    class Program
    {
        private static Hbase.Thrift.Hbase.Client _hbase;
        static byte[] table_name = Encoding.UTF8.GetBytes("vadim_test");
        static readonly byte[] ID = Encoding.UTF8.GetBytes("Id");
        static readonly byte[] NAME = Encoding.UTF8.GetBytes("Name");
        static int i = 0;
        static async Task Main(string[] args)
        {
            int port = 9090;

            string host = args.Length == 1 ? args[0] : "localhost";

            var ip = IPAddress.Parse(host);
            var transport = new TBufferedClientTransport(new TSocketClientTransport(ip, port));
            var proto = new TBinaryProtocol(transport);
            _hbase = new Hbase.Thrift.Hbase.Client(proto);

            try
            {
                await transport.OpenAsync();
                
                var names = await _hbase.getTableNamesAsync(CancellationToken.None);
                names.ForEach(msg => Console.WriteLine(Encoding.UTF8.GetString(msg)));

                await CreateTable();
                await Insert();
                await Get();

                transport.Close();
            }
            catch (Exception e)
            {
                Console.Error.Write(e.ToString());
            }
        }

        private static async Task Get()
        {
            var scanner = await _hbase.scannerOpenAsync(table_name, Guid.Empty.ToByteArray(),
                                             new List<byte[]>() { ID }, new Dictionary<byte[], byte[]>(), CancellationToken.None);
            for (var entry = (await _hbase.scannerGetAsync(scanner, CancellationToken.None)); entry.Count > 0; entry = await _hbase.scannerGetAsync(scanner, CancellationToken.None))
            {
                foreach (var rowResult in entry)
                {
                    Console.Write("{0} => ", new Guid(rowResult.Row));
                    var res = rowResult.Columns.Select(c => BitConverter.ToInt32(c.Value.Value, 0));
                    foreach (var cell in res)
                    {
                        Console.WriteLine("{0}", cell);
                    }
                }
            }
        }

        private static async Task Insert()
        {
            await _hbase.mutateRowsAsync(table_name, new List<BatchMutation>()
            {
                new BatchMutation()
                {
                    Row = Guid.NewGuid().ToByteArray(),
                    Mutations = new List<Mutation> {
                        new Mutation{Column = ID, IsDelete = false, Value = BitConverter.GetBytes(i++) }
                    }
                },
                new BatchMutation()
                {
                    Row = Guid.NewGuid().ToByteArray(),
                    Mutations = new List<Mutation> {
                        new Mutation{Column = ID, IsDelete = false, Value = BitConverter.GetBytes(i++) }
                    }
                }
            }, new Dictionary<byte[], byte[]>(), CancellationToken.None);
        }

        private static async Task CreateTable()
        {
            await _hbase.disableTableAsync(table_name, CancellationToken.None);
            await _hbase.deleteTableAsync(table_name, CancellationToken.None);
            
            await _hbase.createTableAsync(
                table_name,
                new List<ColumnDescriptor>()
                    {
                        new ColumnDescriptor {Name = ID, InMemory = true},
                        new ColumnDescriptor {Name = NAME, InMemory = true}
                    },
                CancellationToken.None
                );
        }
    }
}
