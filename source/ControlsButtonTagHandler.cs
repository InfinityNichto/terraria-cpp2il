using System;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x020000B1 RID: 177
[global::Cpp2ILInjected.Token(Token = "0x20000F8")]
public class ControlsButtonTagHandler : ITagHandler
{
	// Token: 0x060005B6 RID: 1462 RVA: 0x00022C67 File Offset: 0x00020E67
	[global::Cpp2ILInjected.Token(Token = "0x6000680")]
	[global::Cpp2ILInjected.Address(RVA = "0xD18C4C", Offset = "0xD18C4C", Length = "0x16C")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		throw null;
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00022C6A File Offset: 0x00020E6A
	[global::Cpp2ILInjected.Token(Token = "0x6000681")]
	[global::Cpp2ILInjected.Address(RVA = "0xD18DB8", Offset = "0xD18DB8", Length = "0x21C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(ref SpriteFont.CharacterSource),
		typeof(int),
		typeof(ref int),
		typeof(ref Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "MeasureInlineMapping", MemberParameters = new object[]
	{
		typeof(ref SpriteFont.CharacterSource),
		typeof(int),
		typeof(ref int),
		typeof(ref Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromButton", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(GUIControllerInputButton.LinkedControlType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler.ControlsButtonSnippet), Member = "Draw", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(bool),
		typeof(ref Vector2),
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromAxis", MemberParameters = new object[]
	{
		typeof(Axis),
		typeof(float)
	}, ReturnType = typeof(GUIControllerInputButton.AxisControl))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler.ControlsAxisSnippet), Member = "Draw", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.AxisControl),
		typeof(bool),
		typeof(ref Vector2),
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static int DrawButtonControl(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ControllerActionButton action, bool mesaureOnly = false)
	{
		throw null;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00022C6D File Offset: 0x00020E6D
	[global::Cpp2ILInjected.Token(Token = "0x6000682")]
	[global::Cpp2ILInjected.Address(RVA = "0xD1916C", Offset = "0xD1916C", Length = "0x1E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(ref SpriteFont.CharacterSource),
		typeof(int),
		typeof(ref int),
		typeof(ref Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "MeasureInlineMapping", MemberParameters = new object[]
	{
		typeof(ref SpriteFont.CharacterSource),
		typeof(int),
		typeof(ref int),
		typeof(ref Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromButton", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(GUIControllerInputButton.LinkedControlType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler.ControlsButtonSnippet), Member = "Draw", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(bool),
		typeof(ref Vector2),
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromAxis", MemberParameters = new object[]
	{
		typeof(Axis),
		typeof(float)
	}, ReturnType = typeof(GUIControllerInputButton.AxisControl))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler.ControlsAxisSnippet), Member = "Draw", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.AxisControl),
		typeof(bool),
		typeof(ref Vector2),
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static int DrawAxisControl(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ControllerActionVector action, bool mesasure = false)
	{
		throw null;
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00022C70 File Offset: 0x00020E70
	[global::Cpp2ILInjected.Token(Token = "0x6000683")]
	[global::Cpp2ILInjected.Address(RVA = "0xD19354", Offset = "0xD19354", Length = "0x400")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "DrawAxisControl", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(ControllerActionVector),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "DrawButtonControl", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(ControllerActionButton),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static bool PrintInlineMapping(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		throw null;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00022C73 File Offset: 0x00020E73
	[global::Cpp2ILInjected.Token(Token = "0x6000684")]
	[global::Cpp2ILInjected.Address(RVA = "0xD19754", Offset = "0xD19754", Length = "0x478")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "DrawButtonControl", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(ControllerActionButton),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "DrawAxisControl", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float),
		typeof(ControllerActionVector),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static bool MeasureInlineMapping(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		throw null;
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00022C76 File Offset: 0x00020E76
	[global::Cpp2ILInjected.Token(Token = "0x6000685")]
	[global::Cpp2ILInjected.Address(RVA = "0xD19BCC", Offset = "0xD19BCC", Length = "0x1C8")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler.ControlsButtonSnippet), Member = "Draw", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(bool),
		typeof(ref Vector2),
		typeof(SpriteBatch),
		typeof(Vector2),
		typeof(Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		throw null;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00022C79 File Offset: 0x00020E79
	[global::Cpp2ILInjected.Token(Token = "0x6000686")]
	[global::Cpp2ILInjected.Address(RVA = "0xD19D94", Offset = "0xD19D94", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler.ControlsButtonSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(void))]
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

	// Token: 0x060005BD RID: 1469 RVA: 0x00022C7C File Offset: 0x00020E7C
	[global::Cpp2ILInjected.Token(Token = "0x6000687")]
	[global::Cpp2ILInjected.Address(RVA = "0xD19F34", Offset = "0xD19F34", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ControlsButtonTagHandler()
	{
		throw null;
	}

	// Token: 0x020007A9 RID: 1961
	[global::Cpp2ILInjected.Token(Token = "0x20000F9")]
	private class ControlsButtonSnippet : TextSnippet
	{
		// Token: 0x0600489D RID: 18589 RVA: 0x0002EE8C File Offset: 0x0002D08C
		[global::Cpp2ILInjected.Token(Token = "0x6000688")]
		[global::Cpp2ILInjected.Address(RVA = "0xD19EA0", Offset = "0xD19EA0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ControlsButtonSnippet(GUIControllerInputButton.LinkedControlType control)
		{
			throw null;
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x0002EE8F File Offset: 0x0002D08F
		[global::Cpp2ILInjected.Token(Token = "0x6000689")]
		[global::Cpp2ILInjected.Address(RVA = "0xD18FD4", Offset = "0xD18FD4", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler.ControlsButtonSnippet), Member = "UniqueDraw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ref Vector2),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawButtonControl", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ControllerActionButton),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawAxisControl", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ControllerActionVector),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetButtonTexureInformation", MemberParameters = new object[]
		{
			typeof(GUIControllerInputButton.LinkedControlType),
			typeof(ref Rectangle),
			typeof(int)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool Draw(GUIControllerInputButton.LinkedControlType control, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, Vector2 position = default(Vector2), Color color = default(Color), float scale = 1f)
		{
			throw null;
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x0002EE92 File Offset: 0x0002D092
		[global::Cpp2ILInjected.Token(Token = "0x600068A")]
		[global::Cpp2ILInjected.Address(RVA = "0xD1A06C", Offset = "0xD1A06C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler.ControlsButtonSnippet), Member = "Draw", MemberParameters = new object[]
		{
			typeof(GUIControllerInputButton.LinkedControlType),
			typeof(bool),
			typeof(ref Vector2),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(bool))]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, Vector2 position = default(Vector2), Color color = default(Color), float scale = 1f)
		{
			throw null;
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x0002EE95 File Offset: 0x0002D095
		[global::Cpp2ILInjected.Token(Token = "0x600068B")]
		[global::Cpp2ILInjected.Address(RVA = "0xD1A08C", Offset = "0xD1A08C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override float GetStringLength(SpriteFont font)
		{
			throw null;
		}

		// Token: 0x04007973 RID: 31091
		[global::Cpp2ILInjected.Token(Token = "0x40004F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private GUIControllerInputButton.LinkedControlType _control;
	}

	// Token: 0x020007AA RID: 1962
	[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
	public enum MappingType
	{
		// Token: 0x04007975 RID: 31093
		[global::Cpp2ILInjected.Token(Token = "0x40004F7")]
		Movement,
		// Token: 0x04007976 RID: 31094
		[global::Cpp2ILInjected.Token(Token = "0x40004F8")]
		Aim,
		// Token: 0x04007977 RID: 31095
		[global::Cpp2ILInjected.Token(Token = "0x40004F9")]
		Fire,
		// Token: 0x04007978 RID: 31096
		[global::Cpp2ILInjected.Token(Token = "0x40004FA")]
		Jump,
		// Token: 0x04007979 RID: 31097
		[global::Cpp2ILInjected.Token(Token = "0x40004FB")]
		Interact,
		// Token: 0x0400797A RID: 31098
		[global::Cpp2ILInjected.Token(Token = "0x40004FC")]
		OpenInventory,
		// Token: 0x0400797B RID: 31099
		[global::Cpp2ILInjected.Token(Token = "0x40004FD")]
		CloseInventory,
		// Token: 0x0400797C RID: 31100
		[global::Cpp2ILInjected.Token(Token = "0x40004FE")]
		CycleLeftPage,
		// Token: 0x0400797D RID: 31101
		[global::Cpp2ILInjected.Token(Token = "0x40004FF")]
		CycleRightPage,
		// Token: 0x0400797E RID: 31102
		[global::Cpp2ILInjected.Token(Token = "0x4000500")]
		CyclePreviousHotbarItem,
		// Token: 0x0400797F RID: 31103
		[global::Cpp2ILInjected.Token(Token = "0x4000501")]
		CycleNextHotbarItem,
		// Token: 0x04007980 RID: 31104
		[global::Cpp2ILInjected.Token(Token = "0x4000502")]
		SwitchToWorld,
		// Token: 0x04007981 RID: 31105
		[global::Cpp2ILInjected.Token(Token = "0x4000503")]
		CraftItem,
		// Token: 0x04007982 RID: 31106
		[global::Cpp2ILInjected.Token(Token = "0x4000504")]
		PickupItem,
		// Token: 0x04007983 RID: 31107
		[global::Cpp2ILInjected.Token(Token = "0x4000505")]
		EquipItem,
		// Token: 0x04007984 RID: 31108
		[global::Cpp2ILInjected.Token(Token = "0x4000506")]
		Settings,
		// Token: 0x04007985 RID: 31109
		[global::Cpp2ILInjected.Token(Token = "0x4000507")]
		NavigateInventory,
		// Token: 0x04007986 RID: 31110
		[global::Cpp2ILInjected.Token(Token = "0x4000508")]
		Count
	}
}
