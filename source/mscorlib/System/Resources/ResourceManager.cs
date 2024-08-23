using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003F8 RID: 1016
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20004B3")]
	[global::System.Serializable]
	public class ResourceManager
	{
		// Token: 0x06002082 RID: 8322 RVA: 0x0001A012 File Offset: 0x00018212
		[global::Cpp2ILInjected.Token(Token = "0x6002301")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7AD14", Offset = "0x1B7AD14", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		[MethodImpl(8)]
		private void Init()
		{
			throw null;
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x0001A015 File Offset: 0x00018215
		[global::Cpp2ILInjected.Token(Token = "0x6002302")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7AE30", Offset = "0x1B7AE30", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager.ResourceManagerMediator), Member = ".ctor", MemberParameters = new object[] { typeof(ResourceManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected ResourceManager()
		{
			throw null;
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x0001A018 File Offset: 0x00018218
		[global::Cpp2ILInjected.Token(Token = "0x6002303")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7AF78", Offset = "0x1B7AF78", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = "CommonAssemblyInit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		[MethodImpl(8)]
		public ResourceManager(global::System.Type resourceSource)
		{
			throw null;
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0001A01B File Offset: 0x0001821B
		[global::System.Runtime.Serialization.OnDeserializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002304")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7B428", Offset = "0x1B7B428", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x0001A01E File Offset: 0x0001821E
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6002305")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7B438", Offset = "0x1B7B438", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager.ResourceManagerMediator), Member = ".ctor", MemberParameters = new object[] { typeof(ResourceManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(ref UltimateResourceFallbackLocation)
		}, ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0001A021 File Offset: 0x00018221
		[global::System.Runtime.Serialization.OnSerializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002306")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7B5FC", Offset = "0x1B7B5FC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnSerializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x0001A024 File Offset: 0x00018224
		[global::Cpp2ILInjected.Token(Token = "0x6002307")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7B2D4", Offset = "0x1B7B2D4", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager.ResourceManagerMediator), Member = ".ctor", MemberParameters = new object[] { typeof(ResourceManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(ref UltimateResourceFallbackLocation)
		}, ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void CommonAssemblyInit()
		{
			throw null;
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0001A027 File Offset: 0x00018227
		[global::Cpp2ILInjected.Token(Token = "0x17000484")]
		public virtual string BaseName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002308")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7B664", Offset = "0x1B7B664", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0001A02A File Offset: 0x0001822A
		[global::Cpp2ILInjected.Token(Token = "0x17000485")]
		public virtual bool IgnoreCase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002309")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7B66C", Offset = "0x1B7B66C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0001A02D File Offset: 0x0001822D
		[global::Cpp2ILInjected.Token(Token = "0x17000486")]
		protected UltimateResourceFallbackLocation FallbackLocation
		{
			[global::Cpp2ILInjected.Token(Token = "0x600230A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7B674", Offset = "0x1B7B674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x0001A030 File Offset: 0x00018230
		[global::Cpp2ILInjected.Token(Token = "0x600230B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7B67C", Offset = "0x1B7B67C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_HasInvariantCultureName", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "VerifyCultureName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected virtual string GetResourceFileName(global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x0001A033 File Offset: 0x00018233
		[global::Cpp2ILInjected.Token(Token = "0x600230C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7B7AC", Offset = "0x1B7B7AC", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_HasInvariantCultureName", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "GetManifestResourceStream", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManifestBasedResourceGroveler), Member = "CreateResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = "AddResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceSet>),
			typeof(string),
			typeof(ref ResourceSet)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		[MethodImpl(8)]
		public virtual ResourceSet GetResourceSet(global::System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			throw null;
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x0001A036 File Offset: 0x00018236
		[global::Cpp2ILInjected.Token(Token = "0x600230D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7BC98", Offset = "0x1B7BC98", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = "InternalGetResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(ResourceSet))]
		[MethodImpl(8)]
		protected virtual ResourceSet InternalGetResourceSet(global::System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			throw null;
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x0001A039 File Offset: 0x00018239
		[global::Cpp2ILInjected.Token(Token = "0x600230E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7BCBC", Offset = "0x1B7BCBC", Length = "0x7E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = "InternalGetResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceFallbackManager), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CultureInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceFallbackManager), Member = "GetEnumerator", ReturnType = typeof(global::System.Collections.Generic.IEnumerator<global::System.Globalization.CultureInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = "AddResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceSet>),
			typeof(string),
			typeof(ref ResourceSet)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private ResourceSet InternalGetResourceSet(global::System.Globalization.CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0001A03C File Offset: 0x0001823C
		[global::Cpp2ILInjected.Token(Token = "0x600230F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7BB04", Offset = "0x1B7BB04", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = "GetResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = "InternalGetResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "ContainsValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void AddResourceSet(global::System.Collections.Generic.Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
		{
			throw null;
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x0001A03F File Offset: 0x0001823F
		[global::Cpp2ILInjected.Token(Token = "0x6002310")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7C4B0", Offset = "0x1B7C4B0", Length = "0x6E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager.ResourceManagerMediator), Member = "ObtainSatelliteContractVersion", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		protected static global::System.Version GetSatelliteContractVersion(global::System.Reflection.Assembly a)
		{
			throw null;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0001A042 File Offset: 0x00018242
		[global::Cpp2ILInjected.Token(Token = "0x6002311")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7CBF0", Offset = "0x1B7CBF0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = "get_NeutralResourcesCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(ref UltimateResourceFallbackLocation)
		}, ReturnType = typeof(global::System.Globalization.CultureInfo))]
		protected static global::System.Globalization.CultureInfo GetNeutralResourcesLanguage(global::System.Reflection.Assembly a)
		{
			throw null;
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0001A045 File Offset: 0x00018245
		[global::Cpp2ILInjected.Token(Token = "0x6002312")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7A98C", Offset = "0x1B7A98C", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "CanUseDefaultResourceClasses", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static bool CompareNames(string asmTypeName1, string typeName2, global::System.Reflection.AssemblyName asmName2)
		{
			throw null;
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0001A048 File Offset: 0x00018248
		[global::Cpp2ILInjected.Token(Token = "0x6002313")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7B2D0", Offset = "0x1B7B2D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetAppXConfiguration()
		{
			throw null;
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0001A04B File Offset: 0x0001824B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002314")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7CC08", Offset = "0x1B7CC08", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static ResourceManager()
		{
			throw null;
		}

		// Token: 0x0400100E RID: 4110
		[global::Cpp2ILInjected.Token(Token = "0x4001323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected string BaseNameField;

		// Token: 0x0400100F RID: 4111
		[global::System.Obsolete("call InternalGetResourceSet instead")]
		[global::Cpp2ILInjected.Token(Token = "0x4001324")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected global::System.Collections.Hashtable ResourceSets;

		// Token: 0x04001010 RID: 4112
		[global::Cpp2ILInjected.Token(Token = "0x4001325")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private global::System.Collections.Generic.Dictionary<string, ResourceSet> _resourceSets;

		// Token: 0x04001011 RID: 4113
		[global::Cpp2ILInjected.Token(Token = "0x4001326")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string moduleDir;

		// Token: 0x04001012 RID: 4114
		[global::Cpp2ILInjected.Token(Token = "0x4001327")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected global::System.Reflection.Assembly MainAssembly;

		// Token: 0x04001013 RID: 4115
		[global::Cpp2ILInjected.Token(Token = "0x4001328")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Type _locationInfo;

		// Token: 0x04001014 RID: 4116
		[global::Cpp2ILInjected.Token(Token = "0x4001329")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Type _userResourceSet;

		// Token: 0x04001015 RID: 4117
		[global::Cpp2ILInjected.Token(Token = "0x400132A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::System.Globalization.CultureInfo _neutralResourcesCulture;

		// Token: 0x04001016 RID: 4118
		[global::Cpp2ILInjected.Token(Token = "0x400132B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[global::System.NonSerialized]
		private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache;

		// Token: 0x04001017 RID: 4119
		[global::Cpp2ILInjected.Token(Token = "0x400132C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool _ignoreCase;

		// Token: 0x04001018 RID: 4120
		[global::Cpp2ILInjected.Token(Token = "0x400132D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
		private bool UseManifest;

		// Token: 0x04001019 RID: 4121
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x400132E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A")]
		private bool UseSatelliteAssem;

		// Token: 0x0400101A RID: 4122
		[global::System.Runtime.Serialization.OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x400132F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private UltimateResourceFallbackLocation _fallbackLoc;

		// Token: 0x0400101B RID: 4123
		[global::System.Runtime.Serialization.OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x4001330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Version _satelliteContractVersion;

		// Token: 0x0400101C RID: 4124
		[global::System.Runtime.Serialization.OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x4001331")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool _lookedForSatelliteContractVersion;

		// Token: 0x0400101D RID: 4125
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x4001332")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.Reflection.Assembly _callingAssembly;

		// Token: 0x0400101E RID: 4126
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		[global::Cpp2ILInjected.Token(Token = "0x4001333")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private global::System.Reflection.RuntimeAssembly m_callingAssembly;

		// Token: 0x0400101F RID: 4127
		[global::Cpp2ILInjected.Token(Token = "0x4001334")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		[global::System.NonSerialized]
		private IResourceGroveler resourceGroveler;

		// Token: 0x04001020 RID: 4128
		[global::Cpp2ILInjected.Token(Token = "0x4001335")]
		public static readonly int MagicNumber;

		// Token: 0x04001021 RID: 4129
		[global::Cpp2ILInjected.Token(Token = "0x4001336")]
		public static readonly int HeaderVersionNumber;

		// Token: 0x04001022 RID: 4130
		[global::Cpp2ILInjected.Token(Token = "0x4001337")]
		private static readonly global::System.Type _minResourceSet;

		// Token: 0x04001023 RID: 4131
		[global::Cpp2ILInjected.Token(Token = "0x4001338")]
		internal static readonly string ResReaderTypeName;

		// Token: 0x04001024 RID: 4132
		[global::Cpp2ILInjected.Token(Token = "0x4001339")]
		internal static readonly string ResSetTypeName;

		// Token: 0x04001025 RID: 4133
		[global::Cpp2ILInjected.Token(Token = "0x400133A")]
		internal static readonly string MscorlibName;

		// Token: 0x04001026 RID: 4134
		[global::Cpp2ILInjected.Token(Token = "0x400133B")]
		internal static readonly int DEBUG;

		// Token: 0x02000606 RID: 1542
		[global::Cpp2ILInjected.Token(Token = "0x20004B4")]
		internal class CultureNameResourceSetPair
		{
			// Token: 0x06004156 RID: 16726 RVA: 0x0001FE98 File Offset: 0x0001E098
			[global::Cpp2ILInjected.Token(Token = "0x6002315")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7AEFC", Offset = "0x1B7AEFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CultureNameResourceSetPair()
			{
				throw null;
			}
		}

		// Token: 0x02000607 RID: 1543
		[global::Cpp2ILInjected.Token(Token = "0x20004B5")]
		internal class ResourceManagerMediator
		{
			// Token: 0x06004157 RID: 16727 RVA: 0x0001FE9B File Offset: 0x0001E09B
			[global::Cpp2ILInjected.Token(Token = "0x6002316")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7AF04", Offset = "0x1B7AF04", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = "OnDeserialized", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = "CommonAssemblyInit", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal ResourceManagerMediator(ResourceManager rm)
			{
				throw null;
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x06004158 RID: 16728 RVA: 0x0001FE9E File Offset: 0x0001E09E
			[global::Cpp2ILInjected.Token(Token = "0x17000487")]
			internal string ModuleDir
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002317")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B78414", Offset = "0x1B78414", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x06004159 RID: 16729 RVA: 0x0001FEA1 File Offset: 0x0001E0A1
			[global::Cpp2ILInjected.Token(Token = "0x17000488")]
			internal global::System.Type LocationInfo
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002318")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B78194", Offset = "0x1B78194", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x0600415A RID: 16730 RVA: 0x0001FEA4 File Offset: 0x0001E0A4
			[global::Cpp2ILInjected.Token(Token = "0x17000489")]
			internal global::System.Type UserResourceSet
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002319")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B78420", Offset = "0x1B78420", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x0600415B RID: 16731 RVA: 0x0001FEA7 File Offset: 0x0001E0A7
			[global::Cpp2ILInjected.Token(Token = "0x1700048A")]
			internal string BaseNameField
			{
				[global::Cpp2ILInjected.Token(Token = "0x600231A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B78188", Offset = "0x1B78188", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x0600415C RID: 16732 RVA: 0x0001FEAA File Offset: 0x0001E0AA
			[global::Cpp2ILInjected.Token(Token = "0x1700048B")]
			internal global::System.Globalization.CultureInfo NeutralResourcesCulture
			{
				[global::Cpp2ILInjected.Token(Token = "0x600231B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B798CC", Offset = "0x1B798CC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600415D RID: 16733 RVA: 0x0001FEAD File Offset: 0x0001E0AD
			[global::Cpp2ILInjected.Token(Token = "0x600231C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B780D8", Offset = "0x1B780D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string GetResourceFileName(global::System.Globalization.CultureInfo culture)
			{
				throw null;
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x0600415E RID: 16734 RVA: 0x0001FEB0 File Offset: 0x0001E0B0
			// (set) Token: 0x0600415F RID: 16735 RVA: 0x0001FEB3 File Offset: 0x0001E0B3
			[global::Cpp2ILInjected.Token(Token = "0x1700048C")]
			internal bool LookedForSatelliteContractVersion
			{
				[global::Cpp2ILInjected.Token(Token = "0x600231D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7A274", Offset = "0x1B7A274", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600231E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7A2E0", Offset = "0x1B7A2E0", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06004160 RID: 16736 RVA: 0x0001FEB6 File Offset: 0x0001E0B6
			// (set) Token: 0x06004161 RID: 16737 RVA: 0x0001FEB9 File Offset: 0x0001E0B9
			[global::Cpp2ILInjected.Token(Token = "0x1700048D")]
			internal global::System.Version SatelliteContractVersion
			{
				[global::Cpp2ILInjected.Token(Token = "0x600231F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7A358", Offset = "0x1B7A358", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002320")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7A2D4", Offset = "0x1B7A2D4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06004162 RID: 16738 RVA: 0x0001FEBC File Offset: 0x0001E0BC
			[global::Cpp2ILInjected.Token(Token = "0x6002321")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7A280", Offset = "0x1B7A280", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetSatelliteAssembly", MemberParameters = new object[]
			{
				typeof(global::System.Globalization.CultureInfo),
				typeof(ref global::System.Threading.StackCrawlMark)
			}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = "GetSatelliteContractVersion", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(global::System.Version))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal global::System.Version ObtainSatelliteContractVersion(global::System.Reflection.Assembly a)
			{
				throw null;
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x06004163 RID: 16739 RVA: 0x0001FEBF File Offset: 0x0001E0BF
			[global::Cpp2ILInjected.Token(Token = "0x1700048E")]
			internal UltimateResourceFallbackLocation FallbackLoc
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002322")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B787AC", Offset = "0x1B787AC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x06004164 RID: 16740 RVA: 0x0001FEC2 File Offset: 0x0001E0C2
			[global::Cpp2ILInjected.Token(Token = "0x1700048F")]
			internal global::System.Reflection.RuntimeAssembly CallingAssembly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002323")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B79DA0", Offset = "0x1B79DA0", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06004165 RID: 16741 RVA: 0x0001FEC5 File Offset: 0x0001E0C5
			[global::Cpp2ILInjected.Token(Token = "0x17000490")]
			internal global::System.Reflection.RuntimeAssembly MainAssembly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002324")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B787B8", Offset = "0x1B787B8", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GrovelForResourceSet", MemberParameters = new object[]
				{
					typeof(global::System.Globalization.CultureInfo),
					typeof(global::System.Collections.Generic.Dictionary<string, ResourceSet>),
					typeof(bool),
					typeof(bool),
					typeof(ref global::System.Threading.StackCrawlMark)
				}, ReturnType = typeof(ResourceSet))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "CreateResourceSet", MemberParameters = new object[]
				{
					typeof(global::System.IO.Stream),
					typeof(global::System.Reflection.Assembly)
				}, ReturnType = typeof(ResourceSet))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetManifestResourceStream", MemberParameters = new object[]
				{
					typeof(global::System.Reflection.RuntimeAssembly),
					typeof(string),
					typeof(ref global::System.Threading.StackCrawlMark)
				}, ReturnType = typeof(global::System.IO.Stream))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "CaseInsensitiveManifestResourceStreamLookup", MemberParameters = new object[]
				{
					typeof(global::System.Reflection.RuntimeAssembly),
					typeof(string)
				}, ReturnType = typeof(global::System.IO.Stream))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetSatelliteAssembly", MemberParameters = new object[]
				{
					typeof(global::System.Globalization.CultureInfo),
					typeof(ref global::System.Threading.StackCrawlMark)
				}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetSatelliteAssemblyName", ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "HandleSatelliteMissing", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "HandleResourceStreamMissing", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x06004166 RID: 16742 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
			[global::Cpp2ILInjected.Token(Token = "0x17000491")]
			internal string BaseName
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002325")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B7AD04", Offset = "0x1B7AD04", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400199D RID: 6557
			[global::Cpp2ILInjected.Token(Token = "0x400133C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ResourceManager _rm;
		}
	}
}
