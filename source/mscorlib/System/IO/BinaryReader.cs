using System;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;

namespace System.IO
{
	// Token: 0x0200048E RID: 1166
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000561")]
	public class BinaryReader : global::System.IDisposable
	{
		// Token: 0x0600260C RID: 9740 RVA: 0x0001AF0C File Offset: 0x0001910C
		[global::Cpp2ILInjected.Token(Token = "0x600291D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC68F8", Offset = "0x1BC68F8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.UTF8Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BinaryReader(Stream input)
		{
			throw null;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0001AF0F File Offset: 0x0001910F
		[global::Cpp2ILInjected.Token(Token = "0x600291E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6BD8", Offset = "0x1BC6BD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "LoadSpriteFont", MemberParameters = new object[] { typeof(string) }, ReturnType = "Microsoft.Xna.Framework.Graphics.SpriteFont")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryParser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Collections.Generic.Dictionary<string, global::System.Resources.ResourceLocator>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public BinaryReader(Stream input, global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x0001AF12 File Offset: 0x00019112
		[global::Cpp2ILInjected.Token(Token = "0x600291F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6968", Offset = "0x1BC6968", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public BinaryReader(Stream input, global::System.Text.Encoding encoding, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x0001AF15 File Offset: 0x00019115
		[global::Cpp2ILInjected.Token(Token = "0x170005F2")]
		public virtual Stream BaseStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002920")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC6BE0", Offset = "0x1BC6BE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x0001AF18 File Offset: 0x00019118
		[global::Cpp2ILInjected.Token(Token = "0x6002921")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6BE8", Offset = "0x1BC6BE8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x0001AF1B File Offset: 0x0001911B
		[global::Cpp2ILInjected.Token(Token = "0x6002922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6BF8", Offset = "0x1BC6BF8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x0001AF1E File Offset: 0x0001911E
		[global::Cpp2ILInjected.Token(Token = "0x6002923")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6C3C", Offset = "0x1BC6C3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x0001AF21 File Offset: 0x00019121
		[global::Cpp2ILInjected.Token(Token = "0x6002924")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6C4C", Offset = "0x1BC6C4C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
		public virtual int Read()
		{
			throw null;
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x0001AF24 File Offset: 0x00019124
		[global::Cpp2ILInjected.Token(Token = "0x6002925")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6E74", Offset = "0x1BC6E74", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool ReadBoolean()
		{
			throw null;
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x0001AF27 File Offset: 0x00019127
		[global::Cpp2ILInjected.Token(Token = "0x6002926")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6EA8", Offset = "0x1BC6EA8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
		public virtual byte ReadByte()
		{
			throw null;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x0001AF2A File Offset: 0x0001912A
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002927")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6EDC", Offset = "0x1BC6EDC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual sbyte ReadSByte()
		{
			throw null;
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x0001AF2D File Offset: 0x0001912D
		[global::Cpp2ILInjected.Token(Token = "0x6002928")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6F08", Offset = "0x1BC6F08", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
		public virtual char ReadChar()
		{
			throw null;
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0001AF30 File Offset: 0x00019130
		[global::Cpp2ILInjected.Token(Token = "0x6002929")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6F2C", Offset = "0x1BC6F2C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual short ReadInt16()
		{
			throw null;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x0001AF33 File Offset: 0x00019133
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600292A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6F58", Offset = "0x1BC6F58", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual ushort ReadUInt16()
		{
			throw null;
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0001AF36 File Offset: 0x00019136
		[global::Cpp2ILInjected.Token(Token = "0x600292B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6F84", Offset = "0x1BC6F84", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "InternalReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual int ReadInt32()
		{
			throw null;
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x0001AF39 File Offset: 0x00019139
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600292C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC703C", Offset = "0x1BC703C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual uint ReadUInt32()
		{
			throw null;
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x0001AF3C File Offset: 0x0001913C
		[global::Cpp2ILInjected.Token(Token = "0x600292D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7068", Offset = "0x1BC7068", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual long ReadInt64()
		{
			throw null;
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x0001AF3F File Offset: 0x0001913F
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600292E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7094", Offset = "0x1BC7094", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual ulong ReadUInt64()
		{
			throw null;
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x0001AF42 File Offset: 0x00019142
		[global::Cpp2ILInjected.Token(Token = "0x600292F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC70C0", Offset = "0x1BC70C0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.BitConverterLE), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(float))]
		public virtual float ReadSingle()
		{
			throw null;
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x0001AF45 File Offset: 0x00019145
		[global::Cpp2ILInjected.Token(Token = "0x6002930")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC70F0", Offset = "0x1BC70F0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.BitConverterLE), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(double))]
		public virtual double ReadDouble()
		{
			throw null;
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x0001AF48 File Offset: 0x00019148
		[global::Cpp2ILInjected.Token(Token = "0x6002931")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7120", Offset = "0x1BC7120", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual decimal ReadDecimal()
		{
			throw null;
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x0001AF4B File Offset: 0x0001914B
		[global::Cpp2ILInjected.Token(Token = "0x6002932")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC730C", Offset = "0x1BC730C", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = "Read7BitEncodedInt", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public virtual string ReadString()
		{
			throw null;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x0001AF4E File Offset: 0x0001914E
		[global::Cpp2ILInjected.Token(Token = "0x6002933")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7614", Offset = "0x1BC7614", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryReader), Member = "ReadChars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "InternalEmulateRead", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private int InternalReadChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x0001AF51 File Offset: 0x00019151
		[global::Cpp2ILInjected.Token(Token = "0x6002934")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC6C64", Offset = "0x1BC6C64", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private int InternalReadOneChar()
		{
			throw null;
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x0001AF54 File Offset: 0x00019154
		[global::Cpp2ILInjected.Token(Token = "0x6002935")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC78E0", Offset = "0x1BC78E0", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = "InternalReadChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual char[] ReadChars(int count)
		{
			throw null;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x0001AF57 File Offset: 0x00019157
		[global::Cpp2ILInjected.Token(Token = "0x6002936")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7A3C", Offset = "0x1BC7A3C", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual int Read(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x0001AF5A File Offset: 0x0001915A
		[global::Cpp2ILInjected.Token(Token = "0x6002937")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7BAC", Offset = "0x1BC7BAC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual byte[] ReadBytes(int count)
		{
			throw null;
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x0001AF5D File Offset: 0x0001915D
		[global::Cpp2ILInjected.Token(Token = "0x6002938")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7D2C", Offset = "0x1BC7D2C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__Error), Member = "FileNotOpen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected virtual void FillBuffer(int numBytes)
		{
			throw null;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0001AF60 File Offset: 0x00019160
		[global::Cpp2ILInjected.Token(Token = "0x6002939")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7574", Offset = "0x1BC7574", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "SkipString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "LoadString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref global::System.Resources.ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryReader), Member = "ReadString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected internal int Read7BitEncodedInt()
		{
			throw null;
		}

		// Token: 0x040012D3 RID: 4819
		[global::Cpp2ILInjected.Token(Token = "0x400161F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Stream m_stream;

		// Token: 0x040012D4 RID: 4820
		[global::Cpp2ILInjected.Token(Token = "0x4001620")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] m_buffer;

		// Token: 0x040012D5 RID: 4821
		[global::Cpp2ILInjected.Token(Token = "0x4001621")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Text.Decoder m_decoder;

		// Token: 0x040012D6 RID: 4822
		[global::Cpp2ILInjected.Token(Token = "0x4001622")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] m_charBytes;

		// Token: 0x040012D7 RID: 4823
		[global::Cpp2ILInjected.Token(Token = "0x4001623")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private char[] m_singleChar;

		// Token: 0x040012D8 RID: 4824
		[global::Cpp2ILInjected.Token(Token = "0x4001624")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private char[] m_charBuffer;

		// Token: 0x040012D9 RID: 4825
		[global::Cpp2ILInjected.Token(Token = "0x4001625")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int m_maxCharsSize;

		// Token: 0x040012DA RID: 4826
		[global::Cpp2ILInjected.Token(Token = "0x4001626")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool m_2BytesPerChar;

		// Token: 0x040012DB RID: 4827
		[global::Cpp2ILInjected.Token(Token = "0x4001627")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
		private bool m_isMemoryStream;

		// Token: 0x040012DC RID: 4828
		[global::Cpp2ILInjected.Token(Token = "0x4001628")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x46")]
		private bool m_leaveOpen;
	}
}
