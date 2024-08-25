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
	[DebuggerDisplay("Snap Point - {Name} {Id}")]
	[global::Cpp2ILInjected.Token(Token = "0x200071A")]
	public class SnapPoint
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003C2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E01C", Offset = "0x148E01C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "GetSnapPoints", ReturnType = typeof(List<SnapPoint>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SnapPoint(string name, int id, Vector2 anchor, Vector2 offset)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003C2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E170", Offset = "0x148E170", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "GetSnapPoints", ReturnType = typeof(List<SnapPoint>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void ThisIsAHackThatChangesTheSnapPointsInfo(Vector2 anchor, Vector2 offset, int id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007B77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Name;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <Id>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007B79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Vector2 <Position>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4007B7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private Vector2 _anchor;

		[global::Cpp2ILInjected.Token(Token = "0x4007B7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private Vector2 _offset;
	}
}
