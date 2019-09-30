/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;


namespace Hbase.Thrift
{

  /// <summary>
  /// Holds column name and the cell.
  /// </summary>
  public partial class TColumn : TBase
  {
    private byte[] _columnName;
    private TCell _cell;

    public byte[] ColumnName
    {
      get
      {
        return _columnName;
      }
      set
      {
        __isset.columnName = true;
        this._columnName = value;
      }
    }

    public TCell Cell
    {
      get
      {
        return _cell;
      }
      set
      {
        __isset.cell = true;
        this._cell = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool columnName;
      public bool cell;
    }

    public TColumn()
    {
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                ColumnName = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Cell = new TCell();
                await Cell.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("TColumn");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (ColumnName != null && __isset.columnName)
        {
          field.Name = "columnName";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(ColumnName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Cell != null && __isset.cell)
        {
          field.Name = "cell";
          field.Type = TType.Struct;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Cell.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TColumn(");
      bool __first = true;
      if (ColumnName != null && __isset.columnName)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ColumnName: ");
        sb.Append(ColumnName);
      }
      if (Cell != null && __isset.cell)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Cell: ");
        sb.Append(Cell== null ? "<null>" : Cell.ToString());
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
