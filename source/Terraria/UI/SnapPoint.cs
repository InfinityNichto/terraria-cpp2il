using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Elements;

namespace Terraria.UI
{
	// Token: 0x020004CD RID: 1229
	[DebuggerDisplay("Snap Point - {Name} {Id}")]
	[global::Cpp2ILInjected.Token(Token = "0x200071A")]
	public class SnapPoint
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x0002B9FD File Offset: 0x00029BFD
		// (set) Token: 0x060035E7 RID: 13799 RVA: 0x0002BA00 File Offset: 0x00029C00
		[global::Cpp2ILInjected.Token(Token = "0x17000762")]
		public int Id
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C26")]
			[global::Cpp2ILInjected.Address(RVA = "0x148DFFC", Offset = "0x148DFFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C27")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E004", Offset = "0x148E004", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060035E8 RID: 13800 RVA: 0x0002BA03 File Offset: 0x00029C03
		// (set) Token: 0x060035E9 RID: 13801 RVA: 0x0002BA06 File Offset: 0x00029C06
		[global::Cpp2ILInjected.Token(Token = "0x17000763")]
		public Vector2 Position
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C28")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E00C", Offset = "0x148E00C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003C29")]
			[global::Cpp2ILInjected.Address(RVA = "0x148E014", Offset = "0x148E014", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x0002BA09 File Offset: 0x00029C09
		[global::Cpp2ILInjected.Token(Token = "0x6003C2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E01C", Offset = "0x148E01C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "GetSnapPoints", ReturnType = typeof(List<SnapPoint>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SnapPoint(string name, int id, Vector2 anchor, Vector2 offset)
		{
			throw null;
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x0002BA0C File Offset: 0x00029C0C
		[global::Cpp2ILInjected.Token(Token = "0x6003C2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E074", Offset = "0x148E074", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "GetSnapPoint", MemberParameters = new object[] { typeof(ref SnapPoint) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "GetSnapPoints", ReturnType = typeof(List<SnapPoint>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "GetSnapPoints", ReturnType = typeof(List<SnapPoint>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Calculate(UIElement element)
		{
			throw null;
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x0002BA0F File Offset: 0x00029C0F
		[global::Cpp2ILInjected.Token(Token = "0x6003C2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E170", Offset = "0x148E170", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "GetSnapPoints", ReturnType = typeof(List<SnapPoint>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void ThisIsAHackThatChangesTheSnapPointsInfo(Vector2 anchor, Vector2 offset, int id)
		{
			throw null;
		}

		// Token: 0x040066AB RID: 26283
		[global::Cpp2ILInjected.Token(Token = "0x4007B77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x040066AC RID: 26284
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <Id>k__BackingField;

		// Token: 0x040066AD RID: 26285
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Vector2 <Position>k__BackingField;

		// Token: 0x040066AE RID: 26286
		[global::Cpp2ILInjected.Token(Token = "0x4007B7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private Vector2 _anchor;

		// Token: 0x040066AF RID: 26287
		[global::Cpp2ILInjected.Token(Token = "0x4007B7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private Vector2 _offset;
	}
}
