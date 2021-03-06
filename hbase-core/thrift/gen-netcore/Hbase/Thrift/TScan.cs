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
  /// A Scan object is used to specify scanner parameters when opening a scanner.
  /// </summary>
  public partial class TScan : TBase
  {
    private byte[] _startRow;
    private byte[] _stopRow;
    private long _timestamp;
    private List<byte[]> _columns;
    private int _caching;
    private byte[] _filterString;
    private int _batchSize;
    private bool _sortColumns;
    private bool _reversed;
    private bool _cacheBlocks;

    public byte[] StartRow
    {
      get
      {
        return _startRow;
      }
      set
      {
        __isset.startRow = true;
        this._startRow = value;
      }
    }

    public byte[] StopRow
    {
      get
      {
        return _stopRow;
      }
      set
      {
        __isset.stopRow = true;
        this._stopRow = value;
      }
    }

    public long Timestamp
    {
      get
      {
        return _timestamp;
      }
      set
      {
        __isset.timestamp = true;
        this._timestamp = value;
      }
    }

    public List<byte[]> Columns
    {
      get
      {
        return _columns;
      }
      set
      {
        __isset.columns = true;
        this._columns = value;
      }
    }

    public int Caching
    {
      get
      {
        return _caching;
      }
      set
      {
        __isset.caching = true;
        this._caching = value;
      }
    }

    public byte[] FilterString
    {
      get
      {
        return _filterString;
      }
      set
      {
        __isset.filterString = true;
        this._filterString = value;
      }
    }

    public int BatchSize
    {
      get
      {
        return _batchSize;
      }
      set
      {
        __isset.batchSize = true;
        this._batchSize = value;
      }
    }

    public bool SortColumns
    {
      get
      {
        return _sortColumns;
      }
      set
      {
        __isset.sortColumns = true;
        this._sortColumns = value;
      }
    }

    public bool Reversed
    {
      get
      {
        return _reversed;
      }
      set
      {
        __isset.reversed = true;
        this._reversed = value;
      }
    }

    public bool CacheBlocks
    {
      get
      {
        return _cacheBlocks;
      }
      set
      {
        __isset.cacheBlocks = true;
        this._cacheBlocks = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool startRow;
      public bool stopRow;
      public bool timestamp;
      public bool columns;
      public bool caching;
      public bool filterString;
      public bool batchSize;
      public bool sortColumns;
      public bool reversed;
      public bool cacheBlocks;
    }

    public TScan()
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
                StartRow = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                StopRow = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Timestamp = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.List)
              {
                {
                  Columns = new List<byte[]>();
                  TList _list13 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i14 = 0; _i14 < _list13.Count; ++_i14)
                  {
                    byte[] _elem15;
                    _elem15 = await iprot.ReadBinaryAsync(cancellationToken);
                    Columns.Add(_elem15);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                Caching = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                FilterString = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                BatchSize = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Bool)
              {
                SortColumns = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.Bool)
              {
                Reversed = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.Bool)
              {
                CacheBlocks = await iprot.ReadBoolAsync(cancellationToken);
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
        var struc = new TStruct("TScan");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (StartRow != null && __isset.startRow)
        {
          field.Name = "startRow";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(StartRow, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (StopRow != null && __isset.stopRow)
        {
          field.Name = "stopRow";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(StopRow, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.timestamp)
        {
          field.Name = "timestamp";
          field.Type = TType.I64;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Timestamp, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Columns != null && __isset.columns)
        {
          field.Name = "columns";
          field.Type = TType.List;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, Columns.Count), cancellationToken);
            foreach (byte[] _iter16 in Columns)
            {
              await oprot.WriteBinaryAsync(_iter16, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.caching)
        {
          field.Name = "caching";
          field.Type = TType.I32;
          field.ID = 5;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(Caching, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (FilterString != null && __isset.filterString)
        {
          field.Name = "filterString";
          field.Type = TType.String;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(FilterString, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.batchSize)
        {
          field.Name = "batchSize";
          field.Type = TType.I32;
          field.ID = 7;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(BatchSize, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.sortColumns)
        {
          field.Name = "sortColumns";
          field.Type = TType.Bool;
          field.ID = 8;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(SortColumns, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.reversed)
        {
          field.Name = "reversed";
          field.Type = TType.Bool;
          field.ID = 9;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(Reversed, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.cacheBlocks)
        {
          field.Name = "cacheBlocks";
          field.Type = TType.Bool;
          field.ID = 10;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(CacheBlocks, cancellationToken);
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
      var sb = new StringBuilder("TScan(");
      bool __first = true;
      if (StartRow != null && __isset.startRow)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("StartRow: ");
        sb.Append(StartRow);
      }
      if (StopRow != null && __isset.stopRow)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("StopRow: ");
        sb.Append(StopRow);
      }
      if (__isset.timestamp)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Timestamp: ");
        sb.Append(Timestamp);
      }
      if (Columns != null && __isset.columns)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Columns: ");
        sb.Append(Columns);
      }
      if (__isset.caching)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Caching: ");
        sb.Append(Caching);
      }
      if (FilterString != null && __isset.filterString)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("FilterString: ");
        sb.Append(FilterString);
      }
      if (__isset.batchSize)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("BatchSize: ");
        sb.Append(BatchSize);
      }
      if (__isset.sortColumns)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("SortColumns: ");
        sb.Append(SortColumns);
      }
      if (__isset.reversed)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Reversed: ");
        sb.Append(Reversed);
      }
      if (__isset.cacheBlocks)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("CacheBlocks: ");
        sb.Append(CacheBlocks);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
