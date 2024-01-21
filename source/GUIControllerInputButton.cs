using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class GUIControllerInputButton
{
	[Cpp2IlInjected.Token(Token = "0x20007A5")]
	public enum LinkedControlType
	{
		[Cpp2IlInjected.Token(Token = "0x4007992")]
		Action1,
		[Cpp2IlInjected.Token(Token = "0x4007993")]
		Action2,
		[Cpp2IlInjected.Token(Token = "0x4007994")]
		Action3,
		[Cpp2IlInjected.Token(Token = "0x4007995")]
		Action4,
		[Cpp2IlInjected.Token(Token = "0x4007996")]
		LB,
		[Cpp2IlInjected.Token(Token = "0x4007997")]
		RB,
		[Cpp2IlInjected.Token(Token = "0x4007998")]
		LT,
		[Cpp2IlInjected.Token(Token = "0x4007999")]
		RT,
		[Cpp2IlInjected.Token(Token = "0x400799A")]
		View,
		[Cpp2IlInjected.Token(Token = "0x400799B")]
		Options,
		[Cpp2IlInjected.Token(Token = "0x400799C")]
		LeftStick,
		[Cpp2IlInjected.Token(Token = "0x400799D")]
		RightStick
	}

	[Cpp2IlInjected.Token(Token = "0x20007A6")]
	public enum ShoulderButtonControl
	{
		[Cpp2IlInjected.Token(Token = "0x400799F")]
		LB,
		[Cpp2IlInjected.Token(Token = "0x40079A0")]
		RB,
		[Cpp2IlInjected.Token(Token = "0x40079A1")]
		LT,
		[Cpp2IlInjected.Token(Token = "0x40079A2")]
		RT,
		[Cpp2IlInjected.Token(Token = "0x40079A3")]
		View,
		[Cpp2IlInjected.Token(Token = "0x40079A4")]
		Options
	}

	[Cpp2IlInjected.Token(Token = "0x20007A7")]
	public enum AxisControl
	{
		[Cpp2IlInjected.Token(Token = "0x40079A6")]
		DPad,
		[Cpp2IlInjected.Token(Token = "0x40079A7")]
		DPadLeft,
		[Cpp2IlInjected.Token(Token = "0x40079A8")]
		DPadRight,
		[Cpp2IlInjected.Token(Token = "0x40079A9")]
		DPadUp,
		[Cpp2IlInjected.Token(Token = "0x40079AA")]
		DPadDown,
		[Cpp2IlInjected.Token(Token = "0x40079AB")]
		DPadDummy,
		[Cpp2IlInjected.Token(Token = "0x40079AC")]
		LS,
		[Cpp2IlInjected.Token(Token = "0x40079AD")]
		LSLeft,
		[Cpp2IlInjected.Token(Token = "0x40079AE")]
		LSRight,
		[Cpp2IlInjected.Token(Token = "0x40079AF")]
		LSUp,
		[Cpp2IlInjected.Token(Token = "0x40079B0")]
		LSDown,
		[Cpp2IlInjected.Token(Token = "0x40079B1")]
		LSClick,
		[Cpp2IlInjected.Token(Token = "0x40079B2")]
		RS,
		[Cpp2IlInjected.Token(Token = "0x40079B3")]
		RSLeft,
		[Cpp2IlInjected.Token(Token = "0x40079B4")]
		RSRight,
		[Cpp2IlInjected.Token(Token = "0x40079B5")]
		RSUp,
		[Cpp2IlInjected.Token(Token = "0x40079B6")]
		RSDown,
		[Cpp2IlInjected.Token(Token = "0x40079B7")]
		RSClick
	}

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private const ControllerDevice.ControlScheme defaultScheme = ControllerDevice.ControlScheme.CONTROLS_ABXY_XBOX;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	private static Texture2D ButtonControls;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private static Texture2D ShoulderButtonControls;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private static Texture2D AxisControls;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private static Texture2D PS4TouchPad;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x12A06AC", Offset = "0x12A06AC", VA = "0x12A06AC")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x12A07A8", Offset = "0x12A07A8", VA = "0x12A07A8")]
	public static Texture2D GetShoulderButtonTexureInformation(ShoulderButtonControl controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x129D6C4", Offset = "0x129D6C4", VA = "0x129D6C4")]
	public static Texture2D GetAxisTexureInformation(AxisControl controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x129D8B8", Offset = "0x129D8B8", VA = "0x129D8B8")]
	public static Texture2D GetButtonTexureInformation(LinkedControlType controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		return null;
	}
}
