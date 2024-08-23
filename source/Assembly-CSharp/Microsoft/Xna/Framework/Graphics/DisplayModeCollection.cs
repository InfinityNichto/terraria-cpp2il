using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200029D RID: 669
	[global::Cpp2ILInjected.Token(Token = "0x2000360")]
	public class DisplayModeCollection : IEnumerable<DisplayMode>, IEnumerable
	{
		// Token: 0x1700026F RID: 623
		[global::Cpp2ILInjected.Token(Token = "0x17000297")]
		public IEnumerable<DisplayMode> this[SurfaceFormat format]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001689")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA4124", Offset = "0xAA4124", Length = "0x1EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00025A09 File Offset: 0x00023C09
		[global::Cpp2ILInjected.Token(Token = "0x600168A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4310", Offset = "0xAA4310", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "CacheSupportedDisplaySizes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<DisplayMode> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00025A0C File Offset: 0x00023C0C
		[global::Cpp2ILInjected.Token(Token = "0x600168B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA43A0", Offset = "0xAA43A0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00025A0F File Offset: 0x00023C0F
		[global::Cpp2ILInjected.Token(Token = "0x600168C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4430", Offset = "0xAA4430", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "PlatformInitializeAdapters", MemberParameters = new object[] { typeof(ref ReadOnlyCollection<GraphicsAdapter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal DisplayModeCollection(List<DisplayMode> modes)
		{
			throw null;
		}

		// Token: 0x04001EF0 RID: 7920
		[global::Cpp2ILInjected.Token(Token = "0x40024D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<DisplayMode> _modes;

		// Token: 0x02000822 RID: 2082
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000361")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004932 RID: 18738 RVA: 0x0002EFAF File Offset: 0x0002D1AF
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600168D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA4540", Offset = "0xAA4540", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004933 RID: 18739 RVA: 0x0002EFB2 File Offset: 0x0002D1B2
			[global::Cpp2ILInjected.Token(Token = "0x600168E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA459C", Offset = "0xAA459C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004934 RID: 18740 RVA: 0x0002EFB5 File Offset: 0x0002D1B5
			[global::Cpp2ILInjected.Token(Token = "0x600168F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA45A4", Offset = "0xAA45A4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal int <.ctor>b__5_0(DisplayMode a, DisplayMode b)
			{
				throw null;
			}

			// Token: 0x04007DA0 RID: 32160
			[global::Cpp2ILInjected.Token(Token = "0x40024D3")]
			public static readonly DisplayModeCollection.<>c <>9;

			// Token: 0x04007DA1 RID: 32161
			[global::Cpp2ILInjected.Token(Token = "0x40024D4")]
			public static Comparison<DisplayMode> <>9__5_0;
		}
	}
}
