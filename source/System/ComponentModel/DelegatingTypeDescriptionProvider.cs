using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200036A")]
	internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48F0C", Offset = "0x1E48F0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeRemove", MemberParameters = new object[]
		{
			typeof(object),
			typeof(TypeDescriptionProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal DelegatingTypeDescriptionProvider(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700052D")]
		internal TypeDescriptionProvider Provider
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E48F3C", Offset = "0x1E48F3C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
			{
				typeof(IServiceProvider),
				typeof(Type),
				typeof(Type[]),
				typeof(object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetFullComponentName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetExtendedTypeDescriptor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ICustomTypeDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetExtenderProviders", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IExtenderProvider[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetReflectionType", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetRuntimeType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(ICustomTypeDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "IsSupportedType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProviderRecursive", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptionProvider))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48F98", Offset = "0x1E48F98", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48FE0", Offset = "0x1E48FE0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IDictionary GetCache(object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49000", Offset = "0x1E49000", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string GetFullComponentName(object component)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49020", Offset = "0x1E49020", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49040", Offset = "0x1E49040", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49060", Offset = "0x1E49060", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Type GetReflectionType(Type objectType, object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49090", Offset = "0x1E49090", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Type GetRuntimeType(Type objectType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E490B0", Offset = "0x1E490B0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E490E0", Offset = "0x1E490E0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool IsSupportedType(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Type _type;
	}
}
