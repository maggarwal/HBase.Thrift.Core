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
  /// A TRegionInfo contains information about an HTable region.
  /// </summary>
  public partial class TRegionInfo : TBase
  {
    private byte[] _startKey;
    private byte[] _endKey;
    private long _id;
    private byte[] _name;
    private sbyte _version;
    private byte[] _serverName;
    private int _port;

    public byte[] StartKey
    {
      get
      {
        return _startKey;
      }
      set
      {
        __isset.startKey = true;
        this._startKey = value;
      }
    }

    public byte[] EndKey
    {
      get
      {
        return _endKey;
      }
      set
      {
        __isset.endKey = true;
        this._endKey = value;
      }
    }

    public long Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public byte[] Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public sbyte Version
    {
      get
      {
        return _version;
      }
      set
      {
        __isset.version = true;
        this._version = value;
      }
    }

    public byte[] ServerName
    {
      get
      {
        return _serverName;
      }
      set
      {
        __isset.serverName = true;
        this._serverName = value;
      }
    }

    public int Port
    {
      get
      {
        return _port;
      }
      set
      {
        __isset.port = true;
        this._port = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool startKey;
      public bool endKey;
      public bool id;
      public bool name;
      public bool version;
      public bool serverName;
      public bool port;
    }

    public TRegionInfo()
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
                StartKey = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                EndKey = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                Name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Byte)
              {
                Version = await iprot.ReadByteAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                ServerName = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                Port = await iprot.ReadI32Async(cancellationToken);
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
        var struc = new TStruct("TRegionInfo");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (StartKey != null && __isset.startKey)
        {
          field.Name = "startKey";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(StartKey, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (EndKey != null && __isset.endKey)
        {
          field.Name = "endKey";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(EndKey, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.id)
        {
          field.Name = "id";
          field.Type = TType.I64;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Name != null && __isset.name)
        {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.version)
        {
          field.Name = "version";
          field.Type = TType.Byte;
          field.ID = 5;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteByteAsync(Version, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (ServerName != null && __isset.serverName)
        {
          field.Name = "serverName";
          field.Type = TType.String;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(ServerName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.port)
        {
          field.Name = "port";
          field.Type = TType.I32;
          field.ID = 7;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(Port, cancellationToken);
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
      var sb = new StringBuilder("TRegionInfo(");
      bool __first = true;
      if (StartKey != null && __isset.startKey)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("StartKey: ");
        sb.Append(StartKey);
      }
      if (EndKey != null && __isset.endKey)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("EndKey: ");
        sb.Append(EndKey);
      }
      if (__isset.id)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Id: ");
        sb.Append(Id);
      }
      if (Name != null && __isset.name)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Name: ");
        sb.Append(Name);
      }
      if (__isset.version)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Version: ");
        sb.Append(Version);
      }
      if (ServerName != null && __isset.serverName)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ServerName: ");
        sb.Append(ServerName);
      }
      if (__isset.port)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Port: ");
        sb.Append(Port);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
