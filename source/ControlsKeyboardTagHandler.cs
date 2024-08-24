using System;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.UI.Chat;

// Token: 0x020000B2 RID: 178
[global::Cpp2ILInjected.Token(Token = "0x20000FB")]
public class ControlsKeyboardTagHandler : ITagHandler
{
	// Token: 0x060005BE RID: 1470 RVA: 0x00022C7F File Offset: 0x00020E7F
	[global::Cpp2ILInjected.Token(Token = "0x600068C")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1A094", Offset = "0xD1A094", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(SpriteFont),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(ref SpriteFont.CharacterSource),
		typeof(int),
		typeof(ref int),
		typeof(ref Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler.ControlsKeyboardSnippet), Member = "Draw", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool),
		typeof(ref Vector2),
		typeof(SpriteBatch),
		typeof(SpriteFont),
		typeof(Vector2),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	private static void DrawKeyboardBinding(SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 position, Color color, float scale, string bindingText, bool measure = false)
	{
		throw null;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00022C82 File Offset: 0x00020E82
	[global::Cpp2ILInjected.Token(Token = "0x600068D")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1A2C4", Offset = "0xD1A2C4", Length = "0x5E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(Vector2),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(Vector2),
		typeof(Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineRight", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineCentre", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(int),
		typeof(int),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(Vector2[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(int),
		typeof(int),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(Vector2[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(int),
		typeof(int),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(int),
		typeof(int),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(Vector2),
		typeof(Vector2),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "DrawKeyboardBinding", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(SpriteFont),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public static bool PrintInlineMapping(SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		throw null;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00022C85 File Offset: 0x00020E85
	[global::Cpp2ILInjected.Token(Token = "0x600068E")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1A8A8", Offset = "0xD1A8A8", Length = "0x508")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "ApplyMultiLineAlignment", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(ref int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "UpdateText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "MeasureMaxString", MemberParameters = new object[]
	{
		typeof(ref SpriteFont.CharacterSource),
		typeof(ref int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
	{
		typeof(ref SpriteFont.CharacterSource),
		typeof(ref Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static bool MeasureInlineMapping(SpriteFont spriteFont, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 tagSize)
	{
		throw null;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00022C88 File Offset: 0x00020E88
	[global::Cpp2ILInjected.Token(Token = "0x600068F")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1ADB0", Offset = "0xD1ADB0", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler.ControlsKeyboardSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public TextSnippet Parse(string text, Color baseColor = default(Color), string options = null)
	{
		throw null;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x00022C8B File Offset: 0x00020E8B
	[global::Cpp2ILInjected.Token(Token = "0x6000690")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1AF48", Offset = "0xD1AF48", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ControlsKeyboardTagHandler()
	{
		throw null;
	}

	// Token: 0x020007AB RID: 1963
	[global::Cpp2ILInjected.Token(Token = "0x20000FC")]
	public class ControlsKeyboardSnippet : TextSnippet
	{
		// Token: 0x060048A1 RID: 18593 RVA: 0x0002EE98 File Offset: 0x0002D098
		[global::Cpp2ILInjected.Token(Token = "0x6000691")]
		[global::Cpp2ILInjected.Address(RVA = "0xD1AEBC", Offset = "0xD1AEBC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsKeyboardTagHandler), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ControlsKeyboardSnippet(GUIControllerInputButton.LinkedControlType control)
		{
			throw null;
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x0002EE9B File Offset: 0x0002D09B
		[global::Cpp2ILInjected.Token(Token = "0x6000692")]
		[global::Cpp2ILInjected.Address(RVA = "0xD1A120", Offset = "0xD1A120", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsKeyboardTagHandler), Member = "DrawKeyboardBinding", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool Draw(string binding, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 position = default(Vector2), Color color = default(Color), float scale = 1f)
		{
			throw null;
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x0002EE9E File Offset: 0x0002D09E
		[global::Cpp2ILInjected.Token(Token = "0x6000693")]
		[global::Cpp2ILInjected.Address(RVA = "0xD1AF50", Offset = "0xD1AF50", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		public override float GetStringLength(SpriteFont font)
		{
			throw null;
		}

		// Token: 0x04007987 RID: 31111
		[global::Cpp2ILInjected.Token(Token = "0x4000509")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private readonly GUIControllerInputButton.LinkedControlType _control;

		// Token: 0x04007988 RID: 31112
		[global::Cpp2ILInjected.Token(Token = "0x400050A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly string _binding;
	}

	// Token: 0x020007AC RID: 1964
	[global::Cpp2ILInjected.Token(Token = "0x20000FD")]
	public enum MappingType
	{
		// Token: 0x0400798A RID: 31114
		[global::Cpp2ILInjected.Token(Token = "0x400050C")]
		MoveUp,
		// Token: 0x0400798B RID: 31115
		[global::Cpp2ILInjected.Token(Token = "0x400050D")]
		MoveDown,
		// Token: 0x0400798C RID: 31116
		[global::Cpp2ILInjected.Token(Token = "0x400050E")]
		MoveLeft,
		// Token: 0x0400798D RID: 31117
		[global::Cpp2ILInjected.Token(Token = "0x400050F")]
		MoveRight,
		// Token: 0x0400798E RID: 31118
		[global::Cpp2ILInjected.Token(Token = "0x4000510")]
		Aim,
		// Token: 0x0400798F RID: 31119
		[global::Cpp2ILInjected.Token(Token = "0x4000511")]
		Fire,
		// Token: 0x04007990 RID: 31120
		[global::Cpp2ILInjected.Token(Token = "0x4000512")]
		Jump,
		// Token: 0x04007991 RID: 31121
		[global::Cpp2ILInjected.Token(Token = "0x4000513")]
		Interact,
		// Token: 0x04007992 RID: 31122
		[global::Cpp2ILInjected.Token(Token = "0x4000514")]
		InventoryToggle,
		// Token: 0x04007993 RID: 31123
		[global::Cpp2ILInjected.Token(Token = "0x4000515")]
		CycleLeftPage,
		// Token: 0x04007994 RID: 31124
		[global::Cpp2ILInjected.Token(Token = "0x4000516")]
		CycleRightPage,
		// Token: 0x04007995 RID: 31125
		[global::Cpp2ILInjected.Token(Token = "0x4000517")]
		CyclePreviousHotbarItem,
		// Token: 0x04007996 RID: 31126
		[global::Cpp2ILInjected.Token(Token = "0x4000518")]
		CycleNextHotbarItem,
		// Token: 0x04007997 RID: 31127
		[global::Cpp2ILInjected.Token(Token = "0x4000519")]
		SwitchToWorld,
		// Token: 0x04007998 RID: 31128
		[global::Cpp2ILInjected.Token(Token = "0x400051A")]
		CraftItem,
		// Token: 0x04007999 RID: 31129
		[global::Cpp2ILInjected.Token(Token = "0x400051B")]
		PickupItem,
		// Token: 0x0400799A RID: 31130
		[global::Cpp2ILInjected.Token(Token = "0x400051C")]
		EquipItem,
		// Token: 0x0400799B RID: 31131
		[global::Cpp2ILInjected.Token(Token = "0x400051D")]
		Settings,
		// Token: 0x0400799C RID: 31132
		[global::Cpp2ILInjected.Token(Token = "0x400051E")]
		NavigateInventory,
		// Token: 0x0400799D RID: 31133
		[global::Cpp2ILInjected.Token(Token = "0x400051F")]
		Teleport,
		// Token: 0x0400799E RID: 31134
		[global::Cpp2ILInjected.Token(Token = "0x4000520")]
		ZoomIn,
		// Token: 0x0400799F RID: 31135
		[global::Cpp2ILInjected.Token(Token = "0x4000521")]
		ZoomOut,
		// Token: 0x040079A0 RID: 31136
		[global::Cpp2ILInjected.Token(Token = "0x4000522")]
		NavigateHotbar,
		// Token: 0x040079A1 RID: 31137
		[global::Cpp2ILInjected.Token(Token = "0x4000523")]
		Count
	}
}
