using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000533 RID: 1331
	[global::System.Runtime.CompilerServices.TypeDependency("System.Collections.Generic.ObjectComparer`1")]
	[global::Cpp2ILInjected.Token(Token = "0x2000651")]
	[global::System.Serializable]
	public abstract class Comparer<T> : IComparer, IComparer<T>
	{
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x0001C1F3 File Offset: 0x0001A3F3
		[global::Cpp2ILInjected.Token(Token = "0x170007F8")]
		public static Comparer<T> Default
		{
			[global::Cpp2ILInjected.Token(Token = "0x600316C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18F0DB4", Offset = "0x18F0DB4", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x0001C1F6 File Offset: 0x0001A3F6
		[global::Cpp2ILInjected.Token(Token = "0x600316D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F0EA8", Offset = "0x18F0EA8", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private static Comparer<T> CreateComparer()
		{
			throw null;
		}

		// Token: 0x06002CDD RID: 11485
		[global::Cpp2ILInjected.Token(Token = "0x600316E")]
		public abstract int Compare(T x, T y);

		// Token: 0x06002CDE RID: 11486 RVA: 0x0001C1F9 File Offset: 0x0001A3F9
		[global::Cpp2ILInjected.Token(Token = "0x600316F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F1290", Offset = "0x18F1290", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private int System.Collections.IComparer.Compare(object x, object y)
		{
			throw null;
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0001C1FC File Offset: 0x0001A3FC
		[global::Cpp2ILInjected.Token(Token = "0x6003170")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F13E8", Offset = "0x18F13E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Comparer()
		{
			throw null;
		}

		// Token: 0x04001638 RID: 5688
		[global::Cpp2ILInjected.Token(Token = "0x4001AA7")]
		private static Comparer<T> defaultComparer;
	}
}
