using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Buffers
{
	// Token: 0x02000542 RID: 1346
	[global::Cpp2ILInjected.Token(Token = "0x2000660")]
	public abstract class ArrayPool<T>
	{
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x0001C2D4 File Offset: 0x0001A4D4
		[global::Cpp2ILInjected.Token(Token = "0x170007FA")]
		public static ArrayPool<T> Shared
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60031BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C6718", Offset = "0x15C6718", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002D2C RID: 11564
		[global::Cpp2ILInjected.Token(Token = "0x60031BD")]
		public abstract T[] Rent(int minimumLength);

		// Token: 0x06002D2D RID: 11565
		[global::Cpp2ILInjected.Token(Token = "0x60031BE")]
		public abstract void Return(T[] array, bool clearArray = false);

		// Token: 0x06002D2E RID: 11566 RVA: 0x0001C2D7 File Offset: 0x0001A4D7
		[global::Cpp2ILInjected.Token(Token = "0x60031BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C6784", Offset = "0x15C6784", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ArrayPool()
		{
			throw null;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x0001C2DA File Offset: 0x0001A4DA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60031C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C678C", Offset = "0x15C678C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static ArrayPool()
		{
			throw null;
		}

		// Token: 0x0400163A RID: 5690
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001AA9")]
		private static readonly ArrayPool<T> <Shared>k__BackingField;
	}
}
