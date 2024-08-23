using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000002 RID: 2
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public class BindingListenOptions
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002090 File Offset: 0x00000290
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979AF4", Offset = "0x1979AF4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool CallOnBindingFound(PlayerAction playerAction, BindingSource bindingSource)
		{
			throw null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002093 File Offset: 0x00000293
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979B14", Offset = "0x1979B14", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CallOnBindingAdded(PlayerAction playerAction, BindingSource bindingSource)
		{
			throw null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002096 File Offset: 0x00000296
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979B30", Offset = "0x1979B30", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CallOnBindingRejected(PlayerAction playerAction, BindingSource bindingSource, BindingSourceRejectionType bindingSourceRejectionType)
		{
			throw null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002099 File Offset: 0x00000299
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979B4C", Offset = "0x1979B4C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CallOnBindingEnded(PlayerAction playerAction)
		{
			throw null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000209C File Offset: 0x0000029C
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1979B68", Offset = "0x1979B68", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BindingListenOptions()
		{
			throw null;
		}

		// Token: 0x04000001 RID: 1
		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool IncludeControllers;

		// Token: 0x04000002 RID: 2
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		public bool IncludeUnknownControllers;

		// Token: 0x04000003 RID: 3
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		public bool IncludeNonStandardControls;

		// Token: 0x04000004 RID: 4
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x13")]
		public bool IncludeMouseButtons;

		// Token: 0x04000005 RID: 5
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public bool IncludeMouseScrollWheel;

		// Token: 0x04000006 RID: 6
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
		public bool IncludeKeys;

		// Token: 0x04000007 RID: 7
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
		public bool IncludeModifiersAsFirstClassKeys;

		// Token: 0x04000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public uint MaxAllowedBindings;

		// Token: 0x04000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public uint MaxAllowedBindingsPerType;

		// Token: 0x0400000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool AllowDuplicateBindingsPerSet;

		// Token: 0x0400000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		public bool UnsetDuplicateBindingsOnSet;

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		public bool RejectRedundantBindings;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public BindingSource ReplaceBinding;

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Func<PlayerAction, BindingSource, bool> OnBindingFound;

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Action<PlayerAction, BindingSource> OnBindingAdded;

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Action<PlayerAction, BindingSource, BindingSourceRejectionType> OnBindingRejected;

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Action<PlayerAction> OnBindingEnded;
	}
}
