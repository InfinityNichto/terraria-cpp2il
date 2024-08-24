using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;
using Terraria.Social.iOS;
using Terraria.Utilities;

namespace Terraria.Social.Base
{
	// Token: 0x0200038E RID: 910
	[global::Cpp2ILInjected.Token(Token = "0x2000529")]
	public abstract class CloudSocialModule : ISocialModule
	{
		// Token: 0x06002D68 RID: 11624 RVA: 0x0002A227 File Offset: 0x00028427
		[global::Cpp2ILInjected.Token(Token = "0x60031C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x132AAF8", Offset = "0x132AAF8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CloudSocialModule), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Configuration", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "add_OnLoad", MemberParameters = new object[] { typeof(Action<Preferences>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "add_OnSave", MemberParameters = new object[] { typeof(Action<Preferences>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void Initialize()
		{
			throw null;
		}

		// Token: 0x06002D69 RID: 11625
		[global::Cpp2ILInjected.Token(Token = "0x60031C2")]
		public abstract void Shutdown();

		// Token: 0x06002D6A RID: 11626
		[global::Cpp2ILInjected.Token(Token = "0x60031C3")]
		public abstract IEnumerable<string> GetFiles();

		// Token: 0x06002D6B RID: 11627
		[global::Cpp2ILInjected.Token(Token = "0x60031C4")]
		public abstract bool Write(string path, byte[] data, int length);

		// Token: 0x06002D6C RID: 11628
		[global::Cpp2ILInjected.Token(Token = "0x60031C5")]
		public abstract void Read(string path, byte[] buffer, int length);

		// Token: 0x06002D6D RID: 11629
		[global::Cpp2ILInjected.Token(Token = "0x60031C6")]
		public abstract bool HasFile(string path);

		// Token: 0x06002D6E RID: 11630
		[global::Cpp2ILInjected.Token(Token = "0x60031C7")]
		public abstract int GetFileSize(string path);

		// Token: 0x06002D6F RID: 11631
		[global::Cpp2ILInjected.Token(Token = "0x60031C8")]
		public abstract bool Delete(string path);

		// Token: 0x06002D70 RID: 11632
		[global::Cpp2ILInjected.Token(Token = "0x60031C9")]
		public abstract bool Forget(string path);

		// Token: 0x06002D71 RID: 11633 RVA: 0x0002A22A File Offset: 0x0002842A
		[global::Cpp2ILInjected.Token(Token = "0x60031CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x132AC00", Offset = "0x132AC00", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Copy", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public byte[] Read(string path)
		{
			throw null;
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x0002A22D File Offset: 0x0002842D
		[global::Cpp2ILInjected.Token(Token = "0x60031CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x132AC94", Offset = "0x132AC94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Read(string path, byte[] buffer)
		{
			throw null;
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x0002A230 File Offset: 0x00028430
		[global::Cpp2ILInjected.Token(Token = "0x60031CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ACA4", Offset = "0x132ACA4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileUtilities), Member = "Copy", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Write(string path, byte[] data)
		{
			throw null;
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x0002A233 File Offset: 0x00028433
		[global::Cpp2ILInjected.Token(Token = "0x60031CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ACB4", Offset = "0x132ACB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CloudSocialModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CloudSocialModule()
		{
			throw null;
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x0002A236 File Offset: 0x00028436
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60031CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ACBC", Offset = "0x132ACBC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void <Initialize>b__1_0(Preferences preferences)
		{
			throw null;
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x0002A239 File Offset: 0x00028439
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60031CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x132AD38", Offset = "0x132AD38", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <Initialize>b__1_1(Preferences preferences)
		{
			throw null;
		}

		// Token: 0x040031D3 RID: 12755
		[global::Cpp2ILInjected.Token(Token = "0x4003B5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool EnabledByDefault;
	}
}
