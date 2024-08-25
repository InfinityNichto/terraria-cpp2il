using System;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000502")]
	[global::System.Serializable]
	public class CustomAttributeData
	{
		[global::Cpp2ILInjected.Token(Token = "0x600254C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A610", Offset = "0x1B8A610", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomAttributeData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600254D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A618", Offset = "0x1B8A618", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, global::System.IntPtr data, uint data_length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600254E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B819E0", Offset = "0x1B819E0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal CustomAttributeData(ConstructorInfo ctorInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600254F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81D68", Offset = "0x1B81D68", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(CustomAttributeData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CustomAttributeData(ConstructorInfo ctorInfo, global::System.Collections.Generic.IList<CustomAttributeTypedArgument> ctorArgs, global::System.Collections.Generic.IList<CustomAttributeNamedArgument> namedArgs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002550")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A6B0", Offset = "0x1B8A6B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, global::System.IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs);

		[global::Cpp2ILInjected.Token(Token = "0x6002551")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A6B4", Offset = "0x1B8A6B4", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "get_ConstructorArguments", ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeTypedArgument>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "get_NamedArguments", ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeNamedArgument>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData[]), Member = "UnboxValues", MemberTypeParameters = new object[] { typeof(CustomAttributeTypedArgument) }, MemberParameters = new object[] { typeof(object[]) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "AsReadOnly", MemberTypeParameters = new object[] { typeof(CustomAttributeTypedArgument) }, MemberParameters = new object[] { typeof(CustomAttributeTypedArgument[]) }, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = "UnboxValues", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object[]) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "AsReadOnly", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void ResolveArguments()
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x17000526")]
		public virtual ConstructorInfo Constructor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002552")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8A844", Offset = "0x1B8A844", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x17000527")]
		public virtual global::System.Collections.Generic.IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002553")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8A84C", Offset = "0x1B8A84C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000528")]
		public virtual global::System.Collections.Generic.IList<CustomAttributeNamedArgument> NamedArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002554")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8A864", Offset = "0x1B8A864", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002555")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7CB94", Offset = "0x1B7CB94", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "GetSatelliteContractVersion", MemberParameters = new object[] { typeof(Assembly) }, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributes(Assembly target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002556")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A87C", Offset = "0x1B8A87C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002557")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A8D8", Offset = "0x1B8A8D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributesInternal(global::System.RuntimeType target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002558")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A934", Offset = "0x1B8A934", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributes(Module target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002559")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A990", Offset = "0x1B8A990", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000529")]
		public global::System.Type AttributeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600255A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8A9EC", Offset = "0x1B8A9EC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
			{
				typeof(ICustomAttributeProvider),
				typeof(global::System.Type),
				typeof(bool)
			}, ReturnType = typeof(global::System.Collections.Generic.IList<CustomAttributeData>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[]
			{
				typeof(ICustomAttributeProvider),
				typeof(global::System.Type)
			}, ReturnType = typeof(CustomAttributeData[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600255B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A9FC", Offset = "0x1B8A9FC", Length = "0x538")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeNamedArgument), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600255C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1579658", Offset = "0x1579658", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static T[] UnboxValues<T>(object[] values)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600255D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8AF34", Offset = "0x1B8AF34", Length = "0x63C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeNamedArgument), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600255E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8B570", Offset = "0x1B8B570", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeNamedArgument), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40014BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ConstructorInfo ctorInfo;

		[global::Cpp2ILInjected.Token(Token = "0x40014BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Collections.Generic.IList<CustomAttributeTypedArgument> ctorArgs;

		[global::Cpp2ILInjected.Token(Token = "0x40014BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.Generic.IList<CustomAttributeNamedArgument> namedArgs;

		[global::Cpp2ILInjected.Token(Token = "0x40014BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private CustomAttributeData.LazyCAttrData lazyData;

		[global::Cpp2ILInjected.Token(Token = "0x2000503")]
		private class LazyCAttrData
		{
			[global::Cpp2ILInjected.Token(Token = "0x600255F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8A6A8", Offset = "0x1B8A6A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LazyCAttrData()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40014C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal Assembly assembly;

			[global::Cpp2ILInjected.Token(Token = "0x40014C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal global::System.IntPtr data;

			[global::Cpp2ILInjected.Token(Token = "0x40014C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal uint data_length;
		}
	}
}
