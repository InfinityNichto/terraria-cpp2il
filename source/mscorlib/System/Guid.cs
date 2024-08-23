using System;
using System.Buffers;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Versioning;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System
{
	// Token: 0x02000091 RID: 145
	[global::System.Runtime.Versioning.NonVersionable]
	[global::Cpp2ILInjected.Token(Token = "0x20000BD")]
	[global::System.Serializable]
	public struct Guid : global::System.IFormattable, global::System.IComparable, global::System.IComparable<global::System.Guid>, global::System.IEquatable<global::System.Guid>, global::System.ISpanFormattable
	{
		// Token: 0x06000689 RID: 1673 RVA: 0x00015899 File Offset: 0x00013A99
		[global::Cpp2ILInjected.Token(Token = "0x6000728")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DFF4", Offset = "0x1C2DFF4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrPlatform", Member = "StartSession", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "ClientInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FastRandom", Member = "CreateWithRandomSeed", ReturnType = "Terraria.Utilities.FastRandom")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile_OldMobile", Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "CreateMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int)
		}, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "NewUri", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputDevice", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetRandomBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		public unsafe static global::System.Guid NewGuid()
		{
			throw null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001589C File Offset: 0x00013A9C
		[global::Cpp2ILInjected.Token(Token = "0x6000729")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E040", Offset = "0x1C2E040", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.MessageBuffer", Member = "ProcessData", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "GetTutorialMetadata", ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeModule), Member = "GetModuleVersionId", ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Guid>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "ReadType", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Guid(byte[] b)
		{
			throw null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001589F File Offset: 0x00013A9F
		[global::Cpp2ILInjected.Token(Token = "0x600072A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E0D4", Offset = "0x1C2E0D4", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public Guid(global::System.ReadOnlySpan<byte> b)
		{
			throw null;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000158A2 File Offset: 0x00013AA2
		[global::Cpp2ILInjected.Token(Token = "0x600072B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E1F8", Offset = "0x1C2E1F8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.ArrayPoolEventSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			throw null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000158A5 File Offset: 0x00013AA5
		[global::Cpp2ILInjected.Token(Token = "0x600072C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E238", Offset = "0x1C2E238", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.GuidConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToGuid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToGuid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Guid)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertGuid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Guid>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers", Member = "get_MessageTypeId", ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.<>c__DisplayClass6_0", Member = "<InvokeMessageIdSubscribers>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.<>c__DisplayClass7_0", Member = "<AddAndCreate>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.<>c__DisplayClass8_0", Member = "<UnregisterManagedCallback>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection.<>c__DisplayClass12_0", Member = "<Register>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection.<>c__DisplayClass13_0", Member = "<Unregister>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "MessageCallbackInternal", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(ulong),
			typeof(ulong),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Guid.GuidStyles),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "GetGuidParseException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Guid(string g)
		{
			throw null;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000158A8 File Offset: 0x00013AA8
		[global::Cpp2ILInjected.Token(Token = "0x600072D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E6D8", Offset = "0x1C2E6D8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static global::System.Guid Parse(string input)
		{
			throw null;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000158AB File Offset: 0x00013AAB
		[global::Cpp2ILInjected.Token(Token = "0x600072E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E76C", Offset = "0x1C2E76C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Guid.GuidStyles),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "GetGuidParseException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Guid Parse(global::System.ReadOnlySpan<char> input)
		{
			throw null;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000158AE File Offset: 0x00013AAE
		[global::Cpp2ILInjected.Token(Token = "0x600072F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E7D0", Offset = "0x1C2E7D0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Guid.GuidStyles),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool TryParse(string input, out global::System.Guid result)
		{
			throw null;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000158B1 File Offset: 0x00013AB1
		[global::Cpp2ILInjected.Token(Token = "0x6000730")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E860", Offset = "0x1C2E860", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Guid.GuidStyles),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		public static bool TryParse(global::System.ReadOnlySpan<char> input, out global::System.Guid result)
		{
			throw null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000158B4 File Offset: 0x00013AB4
		[global::Cpp2ILInjected.Token(Token = "0x6000731")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E328", Offset = "0x1C2E328", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "Parse", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "TrimStart", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "TrimEnd", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryParseGuidWithDashes", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.Guid.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static bool TryParseGuid(global::System.ReadOnlySpan<char> guidString, global::System.Guid.GuidStyles flags, ref global::System.Guid.GuidResult result)
		{
			throw null;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000158B7 File Offset: 0x00013AB7
		[global::Cpp2ILInjected.Token(Token = "0x6000732")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2EB6C", Offset = "0x1C2EB6C", Length = "0x668")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Guid.GuidStyles),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "EatAllWhitespace", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "IsHexPrefix", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.Guid.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static bool TryParseGuidWithHexPrefix(global::System.ReadOnlySpan<char> guidString, ref global::System.Guid.GuidResult result)
		{
			throw null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000158BA File Offset: 0x00013ABA
		[global::Cpp2ILInjected.Token(Token = "0x6000733")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2F1D4", Offset = "0x1C2F1D4", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Guid.GuidStyles),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(ref long),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.Guid.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool TryParseGuidWithNoStyle(global::System.ReadOnlySpan<char> guidString, ref global::System.Guid.GuidResult result)
		{
			throw null;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000158BD File Offset: 0x00013ABD
		[global::Cpp2ILInjected.Token(Token = "0x6000734")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E8D0", Offset = "0x1C2E8D0", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Guid.GuidStyles),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(ref long),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.Guid.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool TryParseGuidWithDashes(global::System.ReadOnlySpan<char> guidString, ref global::System.Guid.GuidResult result)
		{
			throw null;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000158C0 File Offset: 0x00013AC0
		[global::Cpp2ILInjected.Token(Token = "0x6000735")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2F804", Offset = "0x1C2F804", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		private static bool StringToShort(global::System.ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref global::System.Guid.GuidResult parseResult)
		{
			throw null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000158C3 File Offset: 0x00013AC3
		[global::Cpp2ILInjected.Token(Token = "0x6000736")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2FB88", Offset = "0x1C2FB88", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		private static bool StringToShort(global::System.ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref global::System.Guid.GuidResult parseResult)
		{
			throw null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000158C6 File Offset: 0x00013AC6
		[global::Cpp2ILInjected.Token(Token = "0x6000737")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2F7D8", Offset = "0x1C2F7D8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		private static bool StringToInt(global::System.ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref global::System.Guid.GuidResult parseResult)
		{
			throw null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000158C9 File Offset: 0x00013AC9
		[global::Cpp2ILInjected.Token(Token = "0x6000738")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2F998", Offset = "0x1C2F998", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithDashes", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "StringToShort", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref short),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "StringToShort", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref short),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.Guid.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static bool StringToInt(global::System.ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref global::System.Guid.GuidResult parseResult)
		{
			throw null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000158CC File Offset: 0x00013ACC
		[global::Cpp2ILInjected.Token(Token = "0x6000739")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2F848", Offset = "0x1C2F848", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithDashes", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static bool StringToLong(global::System.ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref global::System.Guid.GuidResult parseResult)
		{
			throw null;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000158CF File Offset: 0x00013ACF
		[global::Cpp2ILInjected.Token(Token = "0x600073A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2F500", Offset = "0x1C2F500", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static global::System.ReadOnlySpan<char> EatAllWhitespace(global::System.ReadOnlySpan<char> str)
		{
			throw null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000158D2 File Offset: 0x00013AD2
		[global::Cpp2ILInjected.Token(Token = "0x600073B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2F714", Offset = "0x1C2F714", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsHexPrefix(global::System.ReadOnlySpan<char> str, int i)
		{
			throw null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000158D5 File Offset: 0x00013AD5
		[global::Cpp2ILInjected.Token(Token = "0x600073C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2FBCC", Offset = "0x1C2FBCC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private void WriteByteHelper(global::System.Span<byte> destination)
		{
			throw null;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000158D8 File Offset: 0x00013AD8
		[global::Cpp2ILInjected.Token(Token = "0x600073D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2FC54", Offset = "0x1C2FC54", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NetMessage", Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			"Terraria.Localization.NetworkText",
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "SaveWorldHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseString", MemberParameters = new object[]
		{
			typeof(char),
			"Newtonsoft.Json.ReadType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsBytes", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(global::System.Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public byte[] ToByteArray()
		{
			throw null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000158DB File Offset: 0x00013ADB
		[global::Cpp2ILInjected.Token(Token = "0x600073E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2FD50", Offset = "0x1C2FD50", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "ClientInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.RichPresenceSocialModule", Member = "PublishPresence", MemberParameters = new object[] { "Terraria.Social.Base.RichPresenceState" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMap", Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "NewUri", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers", Member = "set_MessageTypeId", MemberParameters = new object[] { typeof(global::System.Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents", Member = "InvokeMessageIdSubscribers", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents", Member = "AddAndCreate", MemberParameters = new object[] { typeof(global::System.Guid) }, ReturnType = "UnityEngine.Events.UnityEvent`1<MessageEventArgs>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000158DE File Offset: 0x00013ADE
		[global::Cpp2ILInjected.Token(Token = "0x600073F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2FFC8", Offset = "0x1C2FFC8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FastRandom", Member = "CreateWithRandomSeed", ReturnType = "Terraria.Utilities.FastRandom")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000158E1 File Offset: 0x00013AE1
		[global::Cpp2ILInjected.Token(Token = "0x6000740")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2FFE0", Offset = "0x1C2FFE0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_uuid", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000158E4 File Offset: 0x00013AE4
		[global::Cpp2ILInjected.Token(Token = "0x6000741")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C30088", Offset = "0x1C30088", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(global::System.Guid g)
		{
			throw null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000158E7 File Offset: 0x00013AE7
		[global::Cpp2ILInjected.Token(Token = "0x6000742")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C300CC", Offset = "0x1C300CC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int GetResult(uint me, uint them)
		{
			throw null;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000158EA File Offset: 0x00013AEA
		[global::Cpp2ILInjected.Token(Token = "0x6000743")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C300DC", Offset = "0x1C300DC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int CompareTo(object value)
		{
			throw null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000158ED File Offset: 0x00013AED
		[global::Cpp2ILInjected.Token(Token = "0x6000744")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C30264", Offset = "0x1C30264", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public int CompareTo(global::System.Guid value)
		{
			throw null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000158F0 File Offset: 0x00013AF0
		[global::Cpp2ILInjected.Token(Token = "0x6000745")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C30340", Offset = "0x1C30340", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.SendMessage", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.TrySendMessage", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.<>c__DisplayClass6_0", Member = "<InvokeMessageIdSubscribers>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.<>c__DisplayClass7_0", Member = "<AddAndCreate>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.<>c__DisplayClass8_0", Member = "<UnregisterManagedCallback>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection.<>c__DisplayClass12_0", Member = "<Register>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection.<>c__DisplayClass13_0", Member = "<Unregister>b__0", MemberParameters = new object[] { "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			"UnityEngine.Events.UnityAction`1<MessageEventArgs>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "Send", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			"System.Byte[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "TrySend", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			"System.Byte[]"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static bool operator ==(global::System.Guid a, global::System.Guid b)
		{
			throw null;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000158F3 File Offset: 0x00013AF3
		[global::Cpp2ILInjected.Token(Token = "0x6000746")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C30380", Offset = "0x1C30380", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "AddFrames", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.SendMessage", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.TrySendMessage", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.RegisterInternal", MemberParameters = new object[] { typeof(global::System.Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal", MemberParameters = new object[] { typeof(global::System.Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000158F6 File Offset: 0x00013AF6
		[global::Cpp2ILInjected.Token(Token = "0x6000747")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C30384", Offset = "0x1C30384", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static char HexToChar(int a)
		{
			throw null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000158F9 File Offset: 0x00013AF9
		[global::Cpp2ILInjected.Token(Token = "0x6000748")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C303A0", Offset = "0x1C303A0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		private unsafe static int HexsToChars(char* guidChars, int a, int b)
		{
			throw null;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000158FC File Offset: 0x00013AFC
		[global::Cpp2ILInjected.Token(Token = "0x6000749")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3041C", Offset = "0x1C3041C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		private unsafe static int HexsToCharsHexOutput(char* guidChars, int a, int b)
		{
			throw null;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000158FF File Offset: 0x00013AFF
		[global::Cpp2ILInjected.Token(Token = "0x600074A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2FD98", Offset = "0x1C2FD98", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(global::System.Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[]
		{
			typeof(global::System.Guid),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00015902 File Offset: 0x00013B02
		[global::Cpp2ILInjected.Token(Token = "0x600074B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C304B8", Offset = "0x1C304B8", Length = "0x420")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "System.ISpanFormattable.TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "HexsToChars", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "HexsToCharsHexOutput", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public unsafe bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>))
		{
			throw null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00015905 File Offset: 0x00013B05
		[global::Cpp2ILInjected.Token(Token = "0x600074C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C308D8", Offset = "0x1C308D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(bool))]
		private bool System.ISpanFormattable.TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x04000202 RID: 514
		[global::Cpp2ILInjected.Token(Token = "0x400032D")]
		public static readonly global::System.Guid Empty;

		// Token: 0x04000203 RID: 515
		[global::Cpp2ILInjected.Token(Token = "0x400032E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _a;

		// Token: 0x04000204 RID: 516
		[global::Cpp2ILInjected.Token(Token = "0x400032F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private short _b;

		// Token: 0x04000205 RID: 517
		[global::Cpp2ILInjected.Token(Token = "0x4000330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
		private short _c;

		// Token: 0x04000206 RID: 518
		[global::Cpp2ILInjected.Token(Token = "0x4000331")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private byte _d;

		// Token: 0x04000207 RID: 519
		[global::Cpp2ILInjected.Token(Token = "0x4000332")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
		private byte _e;

		// Token: 0x04000208 RID: 520
		[global::Cpp2ILInjected.Token(Token = "0x4000333")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		private byte _f;

		// Token: 0x04000209 RID: 521
		[global::Cpp2ILInjected.Token(Token = "0x4000334")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB")]
		private byte _g;

		// Token: 0x0400020A RID: 522
		[global::Cpp2ILInjected.Token(Token = "0x4000335")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private byte _h;

		// Token: 0x0400020B RID: 523
		[global::Cpp2ILInjected.Token(Token = "0x4000336")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD")]
		private byte _i;

		// Token: 0x0400020C RID: 524
		[global::Cpp2ILInjected.Token(Token = "0x4000337")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE")]
		private byte _j;

		// Token: 0x0400020D RID: 525
		[global::Cpp2ILInjected.Token(Token = "0x4000338")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF")]
		private byte _k;

		// Token: 0x02000581 RID: 1409
		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x20000BE")]
		private enum GuidStyles
		{
			// Token: 0x040017D3 RID: 6099
			[global::Cpp2ILInjected.Token(Token = "0x400033A")]
			None = 0,
			// Token: 0x040017D4 RID: 6100
			[global::Cpp2ILInjected.Token(Token = "0x400033B")]
			AllowParenthesis = 1,
			// Token: 0x040017D5 RID: 6101
			[global::Cpp2ILInjected.Token(Token = "0x400033C")]
			AllowBraces = 2,
			// Token: 0x040017D6 RID: 6102
			[global::Cpp2ILInjected.Token(Token = "0x400033D")]
			AllowDashes = 4,
			// Token: 0x040017D7 RID: 6103
			[global::Cpp2ILInjected.Token(Token = "0x400033E")]
			AllowHexPrefix = 8,
			// Token: 0x040017D8 RID: 6104
			[global::Cpp2ILInjected.Token(Token = "0x400033F")]
			RequireParenthesis = 16,
			// Token: 0x040017D9 RID: 6105
			[global::Cpp2ILInjected.Token(Token = "0x4000340")]
			RequireBraces = 32,
			// Token: 0x040017DA RID: 6106
			[global::Cpp2ILInjected.Token(Token = "0x4000341")]
			RequireDashes = 64,
			// Token: 0x040017DB RID: 6107
			[global::Cpp2ILInjected.Token(Token = "0x4000342")]
			RequireHexPrefix = 128,
			// Token: 0x040017DC RID: 6108
			[global::Cpp2ILInjected.Token(Token = "0x4000343")]
			HexFormat = 160,
			// Token: 0x040017DD RID: 6109
			[global::Cpp2ILInjected.Token(Token = "0x4000344")]
			NumberFormat = 0,
			// Token: 0x040017DE RID: 6110
			[global::Cpp2ILInjected.Token(Token = "0x4000345")]
			DigitFormat = 64,
			// Token: 0x040017DF RID: 6111
			[global::Cpp2ILInjected.Token(Token = "0x4000346")]
			BraceFormat = 96,
			// Token: 0x040017E0 RID: 6112
			[global::Cpp2ILInjected.Token(Token = "0x4000347")]
			ParenthesisFormat = 80,
			// Token: 0x040017E1 RID: 6113
			[global::Cpp2ILInjected.Token(Token = "0x4000348")]
			Any = 15
		}

		// Token: 0x02000582 RID: 1410
		[global::Cpp2ILInjected.Token(Token = "0x20000BF")]
		private enum GuidParseThrowStyle
		{
			// Token: 0x040017E3 RID: 6115
			[global::Cpp2ILInjected.Token(Token = "0x400034A")]
			None,
			// Token: 0x040017E4 RID: 6116
			[global::Cpp2ILInjected.Token(Token = "0x400034B")]
			All,
			// Token: 0x040017E5 RID: 6117
			[global::Cpp2ILInjected.Token(Token = "0x400034C")]
			AllButOverflow
		}

		// Token: 0x02000583 RID: 1411
		[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
		private enum ParseFailureKind
		{
			// Token: 0x040017E7 RID: 6119
			[global::Cpp2ILInjected.Token(Token = "0x400034E")]
			None,
			// Token: 0x040017E8 RID: 6120
			[global::Cpp2ILInjected.Token(Token = "0x400034F")]
			ArgumentNull,
			// Token: 0x040017E9 RID: 6121
			[global::Cpp2ILInjected.Token(Token = "0x4000350")]
			Format,
			// Token: 0x040017EA RID: 6122
			[global::Cpp2ILInjected.Token(Token = "0x4000351")]
			FormatWithParameter,
			// Token: 0x040017EB RID: 6123
			[global::Cpp2ILInjected.Token(Token = "0x4000352")]
			NativeException,
			// Token: 0x040017EC RID: 6124
			[global::Cpp2ILInjected.Token(Token = "0x4000353")]
			FormatWithInnerException
		}

		// Token: 0x02000584 RID: 1412
		[global::Cpp2ILInjected.Token(Token = "0x20000C1")]
		private struct GuidResult
		{
			// Token: 0x06003F8E RID: 16270 RVA: 0x0001F96A File Offset: 0x0001DB6A
			[global::Cpp2ILInjected.Token(Token = "0x600074D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C308DC", Offset = "0x1C308DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void Init(global::System.Guid.GuidParseThrowStyle canThrow)
			{
				throw null;
			}

			// Token: 0x06003F8F RID: 16271 RVA: 0x0001F96D File Offset: 0x0001DB6D
			[global::Cpp2ILInjected.Token(Token = "0x600074E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2FBBC", Offset = "0x1C2FBBC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void SetFailure(global::System.Exception nativeException)
			{
				throw null;
			}

			// Token: 0x06003F90 RID: 16272 RVA: 0x0001F970 File Offset: 0x0001DB70
			[global::Cpp2ILInjected.Token(Token = "0x600074F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2E8C0", Offset = "0x1C2E8C0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Guid.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			internal void SetFailure(global::System.Guid.ParseFailureKind failure, string failureMessageID)
			{
				throw null;
			}

			// Token: 0x06003F91 RID: 16273 RVA: 0x0001F973 File Offset: 0x0001DB73
			[global::Cpp2ILInjected.Token(Token = "0x6000750")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2F7CC", Offset = "0x1C2F7CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Guid.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			internal void SetFailure(global::System.Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
			{
				throw null;
			}

			// Token: 0x06003F92 RID: 16274 RVA: 0x0001F976 File Offset: 0x0001DB76
			[global::Cpp2ILInjected.Token(Token = "0x6000751")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2F4C0", Offset = "0x1C2F4C0", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Guid.ParseFailureKind",
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Guid.ParseFailureKind",
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				"System.Guid.GuidStyles",
				typeof(ref global::System.Guid.GuidResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref global::System.Guid.GuidResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref global::System.Guid.GuidResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuidWithDashes", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref global::System.Guid.GuidResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref int),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref global::System.Guid.GuidResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid.GuidResult), Member = "GetGuidParseException", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void SetFailure(global::System.Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, global::System.Exception innerException)
			{
				throw null;
			}

			// Token: 0x06003F93 RID: 16275 RVA: 0x0001F979 File Offset: 0x0001DB79
			[global::Cpp2ILInjected.Token(Token = "0x6000752")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2E570", Offset = "0x1C2E570", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid.GuidResult), Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Guid.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "Parse", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.Guid))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal global::System.Exception GetGuidParseException()
			{
				throw null;
			}

			// Token: 0x040017ED RID: 6125
			[global::Cpp2ILInjected.Token(Token = "0x4000354")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal global::System.Guid _parsedGuid;

			// Token: 0x040017EE RID: 6126
			[global::Cpp2ILInjected.Token(Token = "0x4000355")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal global::System.Guid.GuidParseThrowStyle _throwStyle;

			// Token: 0x040017EF RID: 6127
			[global::Cpp2ILInjected.Token(Token = "0x4000356")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private global::System.Guid.ParseFailureKind _failure;

			// Token: 0x040017F0 RID: 6128
			[global::Cpp2ILInjected.Token(Token = "0x4000357")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string _failureMessageID;

			// Token: 0x040017F1 RID: 6129
			[global::Cpp2ILInjected.Token(Token = "0x4000358")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object _failureMessageFormatArgument;

			// Token: 0x040017F2 RID: 6130
			[global::Cpp2ILInjected.Token(Token = "0x4000359")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private string _failureArgumentName;

			// Token: 0x040017F3 RID: 6131
			[global::Cpp2ILInjected.Token(Token = "0x400035A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private global::System.Exception _innerException;
		}
	}
}
