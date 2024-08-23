using System;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Reflection
{
	// Token: 0x02000440 RID: 1088
	[global::System.Runtime.InteropServices.ComDefaultInterface(typeof(global::System.Runtime.InteropServices._Assembly))]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20004FF")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class Assembly : ICustomAttributeProvider, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.InteropServices._Assembly
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x0001A4DA File Offset: 0x000186DA
		[global::Cpp2ILInjected.Token(Token = "0x17000518")]
		public virtual string CodeBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x60024FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B88D38", Offset = "0x1B88D38", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x0001A4DD File Offset: 0x000186DD
		[global::Cpp2ILInjected.Token(Token = "0x17000519")]
		public virtual string EscapedCodeBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x60024FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B88D70", Offset = "0x1B88D70", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x0001A4E0 File Offset: 0x000186E0
		[global::Cpp2ILInjected.Token(Token = "0x1700051A")]
		public virtual string FullName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60024FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B88DA8", Offset = "0x1B88DA8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x0001A4E3 File Offset: 0x000186E3
		[global::Cpp2ILInjected.Token(Token = "0x1700051B")]
		internal virtual global::System.IntPtr MonoAssembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002500")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B88DE0", Offset = "0x1B88DE0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x0001A4E6 File Offset: 0x000186E6
		[global::Cpp2ILInjected.Token(Token = "0x1700051C")]
		public virtual string Location
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002501")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B88E18", Offset = "0x1B88E18", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0001A4E9 File Offset: 0x000186E9
		[global::Cpp2ILInjected.Token(Token = "0x6002502")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88E50", Offset = "0x1B88E50", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x0001A4EC File Offset: 0x000186EC
		[global::Cpp2ILInjected.Token(Token = "0x6002503")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88E88", Offset = "0x1B88E88", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0001A4EF File Offset: 0x000186EF
		[global::Cpp2ILInjected.Token(Token = "0x6002504")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88EC0", Offset = "0x1B88EC0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0001A4F2 File Offset: 0x000186F2
		[global::Cpp2ILInjected.Token(Token = "0x6002505")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88EF8", Offset = "0x1B88EF8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0001A4F5 File Offset: 0x000186F5
		[global::Cpp2ILInjected.Token(Token = "0x6002506")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88F30", Offset = "0x1B88F30", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual global::System.IO.Stream GetManifestResourceStream(string name)
		{
			throw null;
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0001A4F8 File Offset: 0x000186F8
		[global::Cpp2ILInjected.Token(Token = "0x6002507")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B79DAC", Offset = "0x1B79DAC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "GetManifestResourceStream", MemberParameters = new object[]
		{
			typeof(RuntimeAssembly),
			typeof(string),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "CaseInsensitiveManifestResourceStreamLookup", MemberParameters = new object[]
		{
			typeof(RuntimeAssembly),
			typeof(string)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "GetResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Resources.ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Assembly), Member = "GetManifestResourceStream", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Threading.StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal global::System.IO.Stream GetManifestResourceStream(global::System.Type type, string name, bool skipSecurityCheck, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x0001A4FB File Offset: 0x000186FB
		[global::Cpp2ILInjected.Token(Token = "0x6002508")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7A264", Offset = "0x1B7A264", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "GetManifestResourceStream", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.IO.Stream))]
		internal global::System.IO.Stream GetManifestResourceStream(string name, ref global::System.Threading.StackCrawlMark stackMark, bool skipSecurityCheck)
		{
			throw null;
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0001A4FE File Offset: 0x000186FE
		[global::Cpp2ILInjected.Token(Token = "0x6002509")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B79C38", Offset = "0x1B79C38", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "CreateResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(Assembly)
		}, ReturnType = typeof(global::System.Resources.ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "HandleResourceStreamMissing", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal string GetSimpleName()
		{
			throw null;
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0001A501 File Offset: 0x00018701
		[global::Cpp2ILInjected.Token(Token = "0x600250A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7ABDC", Offset = "0x1B7ABDC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal byte[] GetPublicKey()
		{
			throw null;
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x0001A504 File Offset: 0x00018704
		[global::Cpp2ILInjected.Token(Token = "0x600250B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88F68", Offset = "0x1B88F68", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal global::System.Version GetVersion()
		{
			throw null;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0001A507 File Offset: 0x00018707
		[global::Cpp2ILInjected.Token(Token = "0x600250C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88F8C", Offset = "0x1B88F8C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private AssemblyNameFlags GetFlags()
		{
			throw null;
		}

		// Token: 0x06002273 RID: 8819
		[global::Cpp2ILInjected.Token(Token = "0x600250D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88FB0", Offset = "0x1B88FB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal virtual extern global::System.Type[] GetTypes(bool exportedOnly);

		// Token: 0x06002274 RID: 8820 RVA: 0x0001A50A File Offset: 0x0001870A
		[global::Cpp2ILInjected.Token(Token = "0x600250E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88FB8", Offset = "0x1B88FB8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual global::System.Type[] GetTypes()
		{
			throw null;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x0001A50D File Offset: 0x0001870D
		[global::Cpp2ILInjected.Token(Token = "0x600250F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88FCC", Offset = "0x1B88FCC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual global::System.Type GetType(string name, bool throwOnError)
		{
			throw null;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x0001A510 File Offset: 0x00018710
		[global::Cpp2ILInjected.Token(Token = "0x6002510")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88FE4", Offset = "0x1B88FE4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual global::System.Type GetType(string name)
		{
			throw null;
		}

		// Token: 0x06002277 RID: 8823
		[global::Cpp2ILInjected.Token(Token = "0x6002511")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B88FFC", Offset = "0x1B88FFC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern global::System.Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase);

		// Token: 0x06002278 RID: 8824 RVA: 0x0001A513 File Offset: 0x00018713
		[global::Cpp2ILInjected.Token(Token = "0x6002512")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89008", Offset = "0x1B89008", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual AssemblyName GetName(bool copiedName)
		{
			throw null;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x0001A516 File Offset: 0x00018716
		[global::Cpp2ILInjected.Token(Token = "0x6002513")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89040", Offset = "0x1B89040", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual AssemblyName GetName()
		{
			throw null;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0001A519 File Offset: 0x00018719
		[global::Cpp2ILInjected.Token(Token = "0x6002514")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89054", Offset = "0x1B89054", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x0001A51C File Offset: 0x0001871C
		[global::Cpp2ILInjected.Token(Token = "0x6002515")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8905C", Offset = "0x1B8905C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.Converter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Assembly GetAssembly(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x0600227C RID: 8828
		[global::Cpp2ILInjected.Token(Token = "0x6002516")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89118", Offset = "0x1B89118", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaContentSource", Member = "GetTitleLocationPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.RuntimeLicenseContext", Member = "GetSavedLicenseKey", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(Assembly)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern Assembly GetEntryAssembly();

		// Token: 0x0600227D RID: 8829 RVA: 0x0001A51F File Offset: 0x0001871F
		[global::Cpp2ILInjected.Token(Token = "0x6002517")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7A364", Offset = "0x1B7A364", Length = "0x3A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "GetSatelliteAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "set_Version", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(global::System.AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "LoadSatellite", MemberParameters = new object[]
		{
			typeof(AssemblyName),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		internal RuntimeAssembly InternalGetSatelliteAssembly(string name, global::System.Globalization.CultureInfo culture, global::System.Version version, bool throwOnFileNotFound, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x0600227E RID: 8830
		[global::Cpp2ILInjected.Token(Token = "0x6002518")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8915C", Offset = "0x1B8915C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern Assembly LoadFrom(string assemblyFile, bool refOnly, ref global::System.Threading.StackCrawlMark stackMark);

		// Token: 0x0600227F RID: 8831 RVA: 0x0001A522 File Offset: 0x00018722
		[global::Cpp2ILInjected.Token(Token = "0x6002519")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89164", Offset = "0x1B89164", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "ForceLoadAssembly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DelegateSerializationHolder.DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(int)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Resolve", MemberParameters = new object[]
		{
			typeof(global::System.Func<AssemblyName, Assembly>),
			typeof(global::System.Func<Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncodingHelper), Member = "InvokeI18N", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ActivatedClientTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ActivatedServiceTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = "ReadPreload", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.WellKnownClientTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.WellKnownServiceTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(global::System.Runtime.Remoting.WellKnownObjectMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "LoadAssemblyFromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "LoadAssemblyFromStringNoThrow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "FastBindToType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyTabAttribute", Member = "get_TabClasses", ReturnType = "System.Type[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultSerializationBinder", Member = "GetTypeFromTypeNameKey", MemberParameters = new object[] { "Newtonsoft.Json.Serialization.DefaultSerializationBinder.TypeNameKey" }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(global::System.AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Assembly))]
		public static Assembly Load(string assemblyString)
		{
			throw null;
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x0001A525 File Offset: 0x00018725
		[global::Cpp2ILInjected.Token(Token = "0x600251A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89184", Offset = "0x1B89184", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetTypeByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(global::System.AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Policy.Evidence),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(Assembly))]
		[MethodImpl(8)]
		public static Assembly ReflectionOnlyLoad(string assemblyString)
		{
			throw null;
		}

		// Token: 0x06002281 RID: 8833
		[global::Cpp2ILInjected.Token(Token = "0x600251B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B891C4", Offset = "0x1B891C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern Assembly load_with_partial_name(string name, global::System.Security.Policy.Evidence e);

		// Token: 0x06002282 RID: 8834 RVA: 0x0001A528 File Offset: 0x00018728
		[global::System.Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x600251C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B891C8", Offset = "0x1B891C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Assembly LoadWithPartialName(string partialName, global::System.Security.Policy.Evidence securityEvidence)
		{
			throw null;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x0001A52B File Offset: 0x0001872B
		[global::Cpp2ILInjected.Token(Token = "0x600251D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B891D0", Offset = "0x1B891D0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Policy.Evidence),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static Assembly LoadWithPartialName(string partialName, global::System.Security.Policy.Evidence securityEvidence, bool oldBehavior)
		{
			throw null;
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x0001A52E File Offset: 0x0001872E
		[global::Cpp2ILInjected.Token(Token = "0x600251E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89238", Offset = "0x1B89238", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "Refresh", MemberParameters = new object[] { typeof(Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Module[] GetModules()
		{
			throw null;
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x0001A531 File Offset: 0x00018731
		[global::Cpp2ILInjected.Token(Token = "0x600251F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8924C", Offset = "0x1B8924C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal virtual Module[] GetModulesInternal()
		{
			throw null;
		}

		// Token: 0x06002286 RID: 8838
		[global::Cpp2ILInjected.Token(Token = "0x6002520")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89284", Offset = "0x1B89284", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Assembly GetExecutingAssembly();

		// Token: 0x06002287 RID: 8839
		[global::Cpp2ILInjected.Token(Token = "0x6002521")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7AE2C", Offset = "0x1B7AE2C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaContentSource", Member = "GetTitleLocationPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern Assembly GetCallingAssembly();

		// Token: 0x06002288 RID: 8840 RVA: 0x0001A534 File Offset: 0x00018734
		[global::Cpp2ILInjected.Token(Token = "0x6002522")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B892C4", Offset = "0x1B892C4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual string[] GetManifestResourceNames()
		{
			throw null;
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x0001A537 File Offset: 0x00018737
		[global::Cpp2ILInjected.Token(Token = "0x6002523")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B892FC", Offset = "0x1B892FC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			throw null;
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x0001A53A File Offset: 0x0001873A
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700051D")]
		public virtual bool ReflectionOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002524")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B89334", Offset = "0x1B89334", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0001A53D File Offset: 0x0001873D
		[global::Cpp2ILInjected.Token(Token = "0x6002525")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8936C", Offset = "0x1B8936C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x0001A540 File Offset: 0x00018740
		[global::Cpp2ILInjected.Token(Token = "0x6002526")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89374", Offset = "0x1B89374", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x0001A543 File Offset: 0x00018743
		[global::Cpp2ILInjected.Token(Token = "0x6002527")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8937C", Offset = "0x1B8937C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Assembly), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Assembly), Member = "GetModule", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Assembly), Member = "GetModules", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Module[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.Exception CreateNIE()
		{
			throw null;
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x0001A546 File Offset: 0x00018746
		[global::System.MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x1700051E")]
		public bool IsFullyTrusted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002528")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B893E8", Offset = "0x1B893E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "CheckTypeForwardedFrom", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.Formatters.Binary.SerObjectInfoCache),
				typeof(global::System.Type),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0001A549 File Offset: 0x00018749
		[global::Cpp2ILInjected.Token(Token = "0x6002529")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B893F0", Offset = "0x1B893F0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual global::System.Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0001A54C File Offset: 0x0001874C
		[global::Cpp2ILInjected.Token(Token = "0x600252A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89414", Offset = "0x1B89414", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Module GetModule(string name)
		{
			throw null;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0001A54F File Offset: 0x0001874F
		[global::Cpp2ILInjected.Token(Token = "0x600252B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89438", Offset = "0x1B89438", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Module[] GetModules(bool getResourceModules)
		{
			throw null;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x0001A552 File Offset: 0x00018752
		[global::Cpp2ILInjected.Token(Token = "0x1700051F")]
		public virtual bool IsDynamic
		{
			[global::Cpp2ILInjected.Token(Token = "0x600252C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8945C", Offset = "0x1B8945C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x0001A555 File Offset: 0x00018755
		[global::Cpp2ILInjected.Token(Token = "0x600252D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B78960", Offset = "0x1B78960", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(Assembly left, Assembly right)
		{
			throw null;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x0001A558 File Offset: 0x00018758
		[global::Cpp2ILInjected.Token(Token = "0x600252E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B78CB8", Offset = "0x1B78CB8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaContentSource", Member = "GetTitleLocationPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "DoAssemblyResolve", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Assembly),
			typeof(bool)
		}, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "DoTypeResolve", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "DoResourceResolve", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Assembly)
		}, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = "get_NeutralResourcesCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyTabAttribute", Member = "get_TabClasses", ReturnType = "System.Type[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public static bool operator !=(Assembly left, Assembly right)
		{
			throw null;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0001A55B File Offset: 0x0001875B
		[global::Cpp2ILInjected.Token(Token = "0x600252F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89464", Offset = "0x1B89464", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Assembly()
		{
			throw null;
		}

		// Token: 0x0200060A RID: 1546
		[global::Cpp2ILInjected.Token(Token = "0x2000500")]
		internal class ResolveEventHolder
		{
			// Token: 0x06004171 RID: 16753 RVA: 0x0001FEE3 File Offset: 0x0001E0E3
			[global::Cpp2ILInjected.Token(Token = "0x6002530")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8946C", Offset = "0x1B8946C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ResolveEventHolder()
			{
				throw null;
			}
		}
	}
}
