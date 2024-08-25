using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004EE")]
	internal abstract class SignatureHasElementType : SignatureType
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002458")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B843C4", Offset = "0x1B843C4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		protected SignatureHasElementType(SignatureType elementType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E5")]
		public sealed override bool IsGenericTypeDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002459")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84AAC", Offset = "0x1B84AAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600245A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84AB4", Offset = "0x1B84AB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected sealed override bool HasElementTypeImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600245B")]
		protected abstract override bool IsArrayImpl();

		[global::Cpp2ILInjected.Token(Token = "0x600245C")]
		protected abstract override bool IsByRefImpl();

		[global::Cpp2ILInjected.Token(Token = "0x600245D")]
		protected abstract override bool IsPointerImpl();

		[global::Cpp2ILInjected.Token(Token = "0x170004E6")]
		public abstract override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600245E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E7")]
		public abstract override bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600245F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E8")]
		public sealed override bool IsConstructedGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002460")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84ABC", Offset = "0x1B84ABC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E9")]
		public sealed override bool IsGenericParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002461")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84AC4", Offset = "0x1B84AC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004EA")]
		public sealed override bool IsGenericMethodParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002462")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84ACC", Offset = "0x1B84ACC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004EB")]
		public sealed override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002463")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84AD4", Offset = "0x1B84AD4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004EC")]
		internal sealed override SignatureType ElementType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002464")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84AE8", Offset = "0x1B84AE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002465")]
		public abstract override int GetArrayRank();

		[global::Cpp2ILInjected.Token(Token = "0x6002466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84AF0", Offset = "0x1B84AF0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type GetGenericTypeDefinition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84B3C", Offset = "0x1B84B3C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public sealed override global::System.Type[] GetGenericArguments()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004ED")]
		public sealed override global::System.Type[] GenericTypeArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002468")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84BB8", Offset = "0x1B84BB8", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004EE")]
		public sealed override int GenericParameterPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002469")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84C34", Offset = "0x1B84C34", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004EF")]
		public sealed override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600246A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84C80", Offset = "0x1B84C80", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004F0")]
		public sealed override string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x600246B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84CCC", Offset = "0x1B84CCC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600246C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84CE0", Offset = "0x1B84CE0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public sealed override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004F1")]
		protected abstract string Suffix
		{
			[global::Cpp2ILInjected.Token(Token = "0x600246D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400141C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly SignatureType _elementType;
	}
}
