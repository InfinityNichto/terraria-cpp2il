using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004ED")]
	internal sealed class SignatureConstructedGenericType : SignatureType
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B845C0", Offset = "0x1B845C0", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "MakeGenericSignatureType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal SignatureConstructedGenericType(global::System.Type genericTypeDefinition, global::System.Type[] typeArguments)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D9")]
		public sealed override bool IsGenericTypeDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002444")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847A4", Offset = "0x1B847A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002445")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B847AC", Offset = "0x1B847AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool HasElementTypeImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B847B4", Offset = "0x1B847B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsArrayImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002447")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B847BC", Offset = "0x1B847BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsByRefImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002448")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B847C4", Offset = "0x1B847C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool IsPointerImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DA")]
		public sealed override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002449")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847CC", Offset = "0x1B847CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DB")]
		public sealed override bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847D4", Offset = "0x1B847D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DC")]
		public sealed override bool IsConstructedGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847DC", Offset = "0x1B847DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DD")]
		public sealed override bool IsGenericParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847E4", Offset = "0x1B847E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DE")]
		public sealed override bool IsGenericMethodParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847EC", Offset = "0x1B847EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DF")]
		public sealed override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B847F4", Offset = "0x1B847F4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E0")]
		internal sealed override SignatureType ElementType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600244F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8485C", Offset = "0x1B8485C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002450")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84864", Offset = "0x1B84864", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override int GetArrayRank()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002451")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B848B0", Offset = "0x1B848B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public sealed override global::System.Type GetGenericTypeDefinition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002452")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B848B8", Offset = "0x1B848B8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public sealed override global::System.Type[] GetGenericArguments()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E1")]
		public sealed override global::System.Type[] GenericTypeArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002453")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B848C8", Offset = "0x1B848C8", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E2")]
		public sealed override int GenericParameterPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002454")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84938", Offset = "0x1B84938", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E3")]
		public sealed override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002455")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84984", Offset = "0x1B84984", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E4")]
		public sealed override string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002456")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84994", Offset = "0x1B84994", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002457")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B849A8", Offset = "0x1B849A8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public sealed override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400141A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.Type _genericTypeDefinition;

		[global::Cpp2ILInjected.Token(Token = "0x400141B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly global::System.Type[] _genericTypeArguments;
	}
}
