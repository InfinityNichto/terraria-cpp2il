using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;

namespace System.IO
{
	// Token: 0x0200048F RID: 1167
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000562")]
	[global::System.Serializable]
	public class BinaryWriter : global::System.IDisposable
	{
		// Token: 0x06002629 RID: 9769 RVA: 0x0001AF63 File Offset: 0x00019163
		[global::Cpp2ILInjected.Token(Token = "0x600293A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7E4C", Offset = "0x1BC7E4C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryWriter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected BinaryWriter()
		{
			throw null;
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x0001AF66 File Offset: 0x00019166
		[global::Cpp2ILInjected.Token(Token = "0x600293B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7F30", Offset = "0x1BC7F30", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationBroadcast", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationClient", Member = "RequestFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationHost", Member = "RequestFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationOperation_SendFile", Member = "Begin", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationOperation_SendFileList", Member = "SendPlayerFile", MemberParameters = new object[] { "Terraria.IO.PlayerFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationOperation_SendFileList", Member = "SendWorldFile", MemberParameters = new object[] { "Terraria.IO.WorldFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TextureAtlasDB", Member = "Save", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveRecent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NetMessage", Member = "CompressTileBlock", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(short),
			typeof(short),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NetMessage", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "InternalSavePlayerFile", MemberParameters = new object[] { "Terraria.IO.PlayerFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "InternalSaveWorld", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "RenameWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.CachedBuffer", Member = ".ctor", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonWriter", Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BinaryWriter(Stream output)
		{
			throw null;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x0001AF69 File Offset: 0x00019169
		[global::Cpp2ILInjected.Token(Token = "0x600293C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8110", Offset = "0x1BC8110", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter),
			typeof(global::System.Runtime.Serialization.Formatters.FormatterTypeStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerActionSet", Member = "SaveData", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public BinaryWriter(Stream output, global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x0001AF6C File Offset: 0x0001916C
		[global::Cpp2ILInjected.Token(Token = "0x600293D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC7FA8", Offset = "0x1BC7FA8", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public BinaryWriter(Stream output, global::System.Text.Encoding encoding, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x0001AF6F File Offset: 0x0001916F
		[global::Cpp2ILInjected.Token(Token = "0x600293E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8118", Offset = "0x1BC8118", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0001AF72 File Offset: 0x00019172
		[global::Cpp2ILInjected.Token(Token = "0x600293F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8128", Offset = "0x1BC8128", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0001AF75 File Offset: 0x00019175
		[global::Cpp2ILInjected.Token(Token = "0x6002940")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC815C", Offset = "0x1BC815C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x0001AF78 File Offset: 0x00019178
		[global::Cpp2ILInjected.Token(Token = "0x170005F3")]
		public virtual Stream BaseStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002941")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC816C", Offset = "0x1BC816C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x0001AF7B File Offset: 0x0001917B
		[global::Cpp2ILInjected.Token(Token = "0x6002942")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC818C", Offset = "0x1BC818C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Flush()
		{
			throw null;
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x0001AF7E File Offset: 0x0001917E
		[global::Cpp2ILInjected.Token(Token = "0x6002943")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC81A0", Offset = "0x1BC81A0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual long Seek(int offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x0001AF81 File Offset: 0x00019181
		[global::Cpp2ILInjected.Token(Token = "0x6002944")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC81B8", Offset = "0x1BC81B8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(bool value)
		{
			throw null;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x0001AF84 File Offset: 0x00019184
		[global::Cpp2ILInjected.Token(Token = "0x6002945")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC81E4", Offset = "0x1BC81E4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(byte value)
		{
			throw null;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x0001AF87 File Offset: 0x00019187
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002946")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC81F8", Offset = "0x1BC81F8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(sbyte value)
		{
			throw null;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x0001AF8A File Offset: 0x0001918A
		[global::Cpp2ILInjected.Token(Token = "0x6002947")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC820C", Offset = "0x1BC820C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void Write(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x0001AF8D File Offset: 0x0001918D
		[global::Cpp2ILInjected.Token(Token = "0x6002948")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC827C", Offset = "0x1BC827C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x0001AF90 File Offset: 0x00019190
		[global::Cpp2ILInjected.Token(Token = "0x6002949")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8290", Offset = "0x1BC8290", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void Write(char ch)
		{
			throw null;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0001AF93 File Offset: 0x00019193
		[global::Cpp2ILInjected.Token(Token = "0x600294A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC83B4", Offset = "0x1BC83B4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void Write(char[] chars)
		{
			throw null;
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x0001AF96 File Offset: 0x00019196
		[global::Cpp2ILInjected.Token(Token = "0x600294B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8448", Offset = "0x1BC8448", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.BitConverterLE), Member = "GetBytes", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(double value)
		{
			throw null;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x0001AF99 File Offset: 0x00019199
		[global::Cpp2ILInjected.Token(Token = "0x600294C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC847C", Offset = "0x1BC847C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(short value)
		{
			throw null;
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x0001AF9C File Offset: 0x0001919C
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600294D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC84B0", Offset = "0x1BC84B0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(ushort value)
		{
			throw null;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0001AF9F File Offset: 0x0001919F
		[global::Cpp2ILInjected.Token(Token = "0x600294E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC84E4", Offset = "0x1BC84E4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(int value)
		{
			throw null;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0001AFA2 File Offset: 0x000191A2
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600294F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8530", Offset = "0x1BC8530", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(uint value)
		{
			throw null;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0001AFA5 File Offset: 0x000191A5
		[global::Cpp2ILInjected.Token(Token = "0x6002950")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC857C", Offset = "0x1BC857C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(long value)
		{
			throw null;
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0001AFA8 File Offset: 0x000191A8
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002951")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC85F8", Offset = "0x1BC85F8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(ulong value)
		{
			throw null;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x0001AFAB File Offset: 0x000191AB
		[global::Cpp2ILInjected.Token(Token = "0x6002952")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC8674", Offset = "0x1BC8674", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.BitConverterLE), Member = "GetBytes", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(float value)
		{
			throw null;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x0001AFAE File Offset: 0x000191AE
		[global::Cpp2ILInjected.Token(Token = "0x6002953")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC86A8", Offset = "0x1BC86A8", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = "Write7BitEncodedInt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public virtual void Write(string value)
		{
			throw null;
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x0001AFB1 File Offset: 0x000191B1
		[global::Cpp2ILInjected.Token(Token = "0x6002954")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC893C", Offset = "0x1BC893C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void Write7BitEncodedInt(int value)
		{
			throw null;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x0001AFB4 File Offset: 0x000191B4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002955")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC899C", Offset = "0x1BC899C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static BinaryWriter()
		{
			throw null;
		}

		// Token: 0x040012DD RID: 4829
		[global::Cpp2ILInjected.Token(Token = "0x4001629")]
		public static readonly BinaryWriter Null;

		// Token: 0x040012DE RID: 4830
		[global::Cpp2ILInjected.Token(Token = "0x400162A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected Stream OutStream;

		// Token: 0x040012DF RID: 4831
		[global::Cpp2ILInjected.Token(Token = "0x400162B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] _buffer;

		// Token: 0x040012E0 RID: 4832
		[global::Cpp2ILInjected.Token(Token = "0x400162C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Text.Encoding _encoding;

		// Token: 0x040012E1 RID: 4833
		[global::Cpp2ILInjected.Token(Token = "0x400162D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Text.Encoder _encoder;

		// Token: 0x040012E2 RID: 4834
		[global::System.Runtime.Serialization.OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x400162E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _leaveOpen;

		// Token: 0x040012E3 RID: 4835
		[global::Cpp2ILInjected.Token(Token = "0x400162F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private byte[] _largeByteBuffer;

		// Token: 0x040012E4 RID: 4836
		[global::Cpp2ILInjected.Token(Token = "0x4001630")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _maxChars;
	}
}
