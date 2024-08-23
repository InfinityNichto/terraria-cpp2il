using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000537 RID: 1335
	[global::System.Runtime.CompilerServices.TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
	[global::Cpp2ILInjected.Token(Token = "0x2000655")]
	[global::System.Serializable]
	public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
	{
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x0001C223 File Offset: 0x0001A423
		[global::Cpp2ILInjected.Token(Token = "0x170007F9")]
		public static EqualityComparer<T> Default
		{
			[global::Cpp2ILInjected.Token(Token = "0x600317D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1664820", Offset = "0x1664820", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0001C226 File Offset: 0x0001A426
		[global::Cpp2ILInjected.Token(Token = "0x600317E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1664914", Offset = "0x1664914", Length = "0x630")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ByteEqualityComparer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalStringComparer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		private static EqualityComparer<T> CreateComparer()
		{
			throw null;
		}

		// Token: 0x06002CEE RID: 11502
		[global::Cpp2ILInjected.Token(Token = "0x600317F")]
		public abstract bool Equals(T x, T y);

		// Token: 0x06002CEF RID: 11503
		[global::Cpp2ILInjected.Token(Token = "0x6003180")]
		public abstract int GetHashCode(T obj);

		// Token: 0x06002CF0 RID: 11504 RVA: 0x0001C229 File Offset: 0x0001A429
		[global::Cpp2ILInjected.Token(Token = "0x6003181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1664F44", Offset = "0x1664F44", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual int IndexOf(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0001C22C File Offset: 0x0001A42C
		[global::Cpp2ILInjected.Token(Token = "0x6003182")]
		[global::Cpp2ILInjected.Address(RVA = "0x1664FCC", Offset = "0x1664FCC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x0001C22F File Offset: 0x0001A42F
		[global::Cpp2ILInjected.Token(Token = "0x6003183")]
		[global::Cpp2ILInjected.Address(RVA = "0x166504C", Offset = "0x166504C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int System.Collections.IEqualityComparer.GetHashCode(object obj)
		{
			throw null;
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x0001C232 File Offset: 0x0001A432
		[global::Cpp2ILInjected.Token(Token = "0x6003184")]
		[global::Cpp2ILInjected.Address(RVA = "0x1665108", Offset = "0x1665108", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool System.Collections.IEqualityComparer.Equals(object x, object y)
		{
			throw null;
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x0001C235 File Offset: 0x0001A435
		[global::Cpp2ILInjected.Token(Token = "0x6003185")]
		[global::Cpp2ILInjected.Address(RVA = "0x1665260", Offset = "0x1665260", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected EqualityComparer()
		{
			throw null;
		}

		// Token: 0x04001639 RID: 5689
		[global::Cpp2ILInjected.Token(Token = "0x4001AA8")]
		private static EqualityComparer<T> defaultComparer;
	}
}
