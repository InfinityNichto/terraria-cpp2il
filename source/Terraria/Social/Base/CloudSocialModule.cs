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
	[global::Cpp2ILInjected.Token(Token = "0x2000529")]
	public abstract class CloudSocialModule : ISocialModule
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60031C2")]
		public abstract void Shutdown();

		[global::Cpp2ILInjected.Token(Token = "0x60031C3")]
		public abstract IEnumerable<string> GetFiles();

		[global::Cpp2ILInjected.Token(Token = "0x60031C4")]
		public abstract bool Write(string path, byte[] data, int length);

		[global::Cpp2ILInjected.Token(Token = "0x60031C5")]
		public abstract void Read(string path, byte[] buffer, int length);

		[global::Cpp2ILInjected.Token(Token = "0x60031C6")]
		public abstract bool HasFile(string path);

		[global::Cpp2ILInjected.Token(Token = "0x60031C7")]
		public abstract int GetFileSize(string path);

		[global::Cpp2ILInjected.Token(Token = "0x60031C8")]
		public abstract bool Delete(string path);

		[global::Cpp2ILInjected.Token(Token = "0x60031C9")]
		public abstract bool Forget(string path);

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

		[global::Cpp2ILInjected.Token(Token = "0x60031CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x132AC94", Offset = "0x132AC94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Read(string path, byte[] buffer)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60031CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ACB4", Offset = "0x132ACB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CloudSocialModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CloudSocialModule()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4003B5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool EnabledByDefault;
	}
}
