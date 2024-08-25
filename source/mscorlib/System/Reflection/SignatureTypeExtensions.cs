using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004F1")]
	internal static class SignatureTypeExtensions
	{
		[global::Cpp2ILInjected.Token(Token = "0x60024C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85E24", Offset = "0x1B85E24", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectMethod", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(MethodBase[]),
			typeof(global::System.Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new object[]
		{
			typeof(MethodBase),
			typeof(BindingFlags),
			typeof(BindingFlags),
			typeof(CallingConventions),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool MatchesParameterTypeExactly(this global::System.Type pattern, ParameterInfo parameter)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85ED0", Offset = "0x1B85ED0", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool MatchesExactly(this SignatureType pattern, global::System.Type actual)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86218", Offset = "0x1B86218", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectMethod", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(MethodBase[]),
			typeof(global::System.Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static global::System.Type TryResolveAgainstGenericMethod(this SignatureType signatureType, MethodInfo genericMethod)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86248", Offset = "0x1B86248", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeArrayType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeByRefType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakePointerType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeGenericType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.Type TryResolve(this SignatureType signatureType, global::System.Type[] genericMethodParameters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B865A0", Offset = "0x1B865A0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.Type TryMakeArrayType(this global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86630", Offset = "0x1B86630", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.Type TryMakeArrayType(this global::System.Type type, int rank)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B866C0", Offset = "0x1B866C0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.Type TryMakeByRefType(this global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86750", Offset = "0x1B86750", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.Type TryMakePointerType(this global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B867E0", Offset = "0x1B867E0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.Type TryMakeGenericType(this global::System.Type type, global::System.Type[] instantiation)
		{
			throw null;
		}
	}
}
