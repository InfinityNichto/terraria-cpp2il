using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004E6")]
	public class SimpleStructure : GenStructure
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000608")]
		public int Width
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003065")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FB6D4", Offset = "0x12FB6D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000609")]
		public int Height
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003066")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FB6DC", Offset = "0x12FB6DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003067")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FB6E4", Offset = "0x12FB6E4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SimpleStructure(params string[] data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003068")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FB81C", Offset = "0x12FB81C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleStructure), Member = "ReadData", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		public SimpleStructure(string data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003069")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FB710", Offset = "0x12FB710", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleStructure), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ReadData(string[] lines)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600306A")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FB85C", Offset = "0x12FB85C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SimpleStructure SetActions(params GenAction[] actions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600306B")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FB864", Offset = "0x12FB864", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SimpleStructure Mirror(bool horizontalMirror, bool verticalMirror)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600306C")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FB878", Offset = "0x12FB878", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "AddProtectedStructure", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Place(Point origin, StructureMap structures)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003A81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int[,] _data;

		[global::Cpp2ILInjected.Token(Token = "0x4003A82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _width;

		[global::Cpp2ILInjected.Token(Token = "0x4003A83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _height;

		[global::Cpp2ILInjected.Token(Token = "0x4003A84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private GenAction[] _actions;

		[global::Cpp2ILInjected.Token(Token = "0x4003A85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _xMirror;

		[global::Cpp2ILInjected.Token(Token = "0x4003A86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _yMirror;
	}
}
