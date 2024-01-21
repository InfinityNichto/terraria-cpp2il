using System;
using Cpp2IlInjected;
using Newtonsoft.Json;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200029C")]
[JsonObject]
public struct Color : IEquatable<Color>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001E52")]
	[JsonProperty]
	public byte A;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4001E53")]
	[JsonProperty]
	public byte B;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4001E54")]
	[JsonProperty]
	public byte G;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4001E55")]
	[JsonProperty]
	public byte R;

	[Cpp2IlInjected.Token(Token = "0x4001E56")]
	public static readonly Color Transparent;

	[Cpp2IlInjected.Token(Token = "0x4001E57")]
	public static readonly Color TransparentBlack;

	[Cpp2IlInjected.Token(Token = "0x4001E58")]
	public static readonly Color TransparentWhite;

	[Cpp2IlInjected.Token(Token = "0x4001E59")]
	public static readonly Color AliceBlue;

	[Cpp2IlInjected.Token(Token = "0x4001E5A")]
	public static readonly Color AntiqueWhite;

	[Cpp2IlInjected.Token(Token = "0x4001E5B")]
	public static readonly Color Aqua;

	[Cpp2IlInjected.Token(Token = "0x4001E5C")]
	public static readonly Color Aquamarine;

	[Cpp2IlInjected.Token(Token = "0x4001E5D")]
	public static readonly Color Azure;

	[Cpp2IlInjected.Token(Token = "0x4001E5E")]
	public static readonly Color Beige;

	[Cpp2IlInjected.Token(Token = "0x4001E5F")]
	public static readonly Color Bisque;

	[Cpp2IlInjected.Token(Token = "0x4001E60")]
	public static readonly Color Black;

	[Cpp2IlInjected.Token(Token = "0x4001E61")]
	public static readonly Color BlanchedAlmond;

	[Cpp2IlInjected.Token(Token = "0x4001E62")]
	public static readonly Color Blue;

	[Cpp2IlInjected.Token(Token = "0x4001E63")]
	public static readonly Color BlueViolet;

	[Cpp2IlInjected.Token(Token = "0x4001E64")]
	public static readonly Color Brown;

	[Cpp2IlInjected.Token(Token = "0x4001E65")]
	public static readonly Color BurlyWood;

	[Cpp2IlInjected.Token(Token = "0x4001E66")]
	public static readonly Color CadetBlue;

	[Cpp2IlInjected.Token(Token = "0x4001E67")]
	public static readonly Color Chartreuse;

	[Cpp2IlInjected.Token(Token = "0x4001E68")]
	public static readonly Color Chocolate;

	[Cpp2IlInjected.Token(Token = "0x4001E69")]
	public static readonly Color Coral;

	[Cpp2IlInjected.Token(Token = "0x4001E6A")]
	public static readonly Color CornflowerBlue;

	[Cpp2IlInjected.Token(Token = "0x4001E6B")]
	public static readonly Color Cornsilk;

	[Cpp2IlInjected.Token(Token = "0x4001E6C")]
	public static readonly Color Crimson;

	[Cpp2IlInjected.Token(Token = "0x4001E6D")]
	public static readonly Color Cyan;

	[Cpp2IlInjected.Token(Token = "0x4001E6E")]
	public static readonly Color DarkBlue;

	[Cpp2IlInjected.Token(Token = "0x4001E6F")]
	public static readonly Color DarkCyan;

	[Cpp2IlInjected.Token(Token = "0x4001E70")]
	public static readonly Color DarkGoldenrod;

	[Cpp2IlInjected.Token(Token = "0x4001E71")]
	public static readonly Color DarkGray;

	[Cpp2IlInjected.Token(Token = "0x4001E72")]
	public static readonly Color DarkGreen;

	[Cpp2IlInjected.Token(Token = "0x4001E73")]
	public static readonly Color DarkKhaki;

	[Cpp2IlInjected.Token(Token = "0x4001E74")]
	public static readonly Color DarkMagenta;

	[Cpp2IlInjected.Token(Token = "0x4001E75")]
	public static readonly Color DarkOliveGreen;

	[Cpp2IlInjected.Token(Token = "0x4001E76")]
	public static readonly Color DarkOrange;

	[Cpp2IlInjected.Token(Token = "0x4001E77")]
	public static readonly Color DarkOrchid;

	[Cpp2IlInjected.Token(Token = "0x4001E78")]
	public static readonly Color DarkRed;

	[Cpp2IlInjected.Token(Token = "0x4001E79")]
	public static readonly Color DarkSalmon;

	[Cpp2IlInjected.Token(Token = "0x4001E7A")]
	public static readonly Color DarkSeaGreen;

	[Cpp2IlInjected.Token(Token = "0x4001E7B")]
	public static readonly Color DarkSlateBlue;

	[Cpp2IlInjected.Token(Token = "0x4001E7C")]
	public static readonly Color DarkSlateGray;

	[Cpp2IlInjected.Token(Token = "0x4001E7D")]
	public static readonly Color DarkTurquoise;

	[Cpp2IlInjected.Token(Token = "0x4001E7E")]
	public static readonly Color DarkViolet;

	[Cpp2IlInjected.Token(Token = "0x4001E7F")]
	public static readonly Color DeepPink;

	[Cpp2IlInjected.Token(Token = "0x4001E80")]
	public static readonly Color DeepSkyBlue;

	[Cpp2IlInjected.Token(Token = "0x4001E81")]
	public static readonly Color DimGray;

	[Cpp2IlInjected.Token(Token = "0x4001E82")]
	public static readonly Color DodgerBlue;

	[Cpp2IlInjected.Token(Token = "0x4001E83")]
	public static readonly Color Firebrick;

	[Cpp2IlInjected.Token(Token = "0x4001E84")]
	public static readonly Color FloralWhite;

	[Cpp2IlInjected.Token(Token = "0x4001E85")]
	public static readonly Color ForestGreen;

	[Cpp2IlInjected.Token(Token = "0x4001E86")]
	public static readonly Color Fuchsia;

	[Cpp2IlInjected.Token(Token = "0x4001E87")]
	public static readonly Color Gainsboro;

	[Cpp2IlInjected.Token(Token = "0x4001E88")]
	public static readonly Color GhostWhite;

	[Cpp2IlInjected.Token(Token = "0x4001E89")]
	public static readonly Color Gold;

	[Cpp2IlInjected.Token(Token = "0x4001E8A")]
	public static readonly Color Goldenrod;

	[Cpp2IlInjected.Token(Token = "0x4001E8B")]
	public static readonly Color Gray;

	[Cpp2IlInjected.Token(Token = "0x4001E8C")]
	public static readonly Color Green;

	[Cpp2IlInjected.Token(Token = "0x4001E8D")]
	public static readonly Color GreenYellow;

	[Cpp2IlInjected.Token(Token = "0x4001E8E")]
	public static readonly Color Honeydew;

	[Cpp2IlInjected.Token(Token = "0x4001E8F")]
	public static readonly Color HotPink;

	[Cpp2IlInjected.Token(Token = "0x4001E90")]
	public static readonly Color IndianRed;

	[Cpp2IlInjected.Token(Token = "0x4001E91")]
	public static readonly Color Indigo;

	[Cpp2IlInjected.Token(Token = "0x4001E92")]
	public static readonly Color Ivory;

	[Cpp2IlInjected.Token(Token = "0x4001E93")]
	public static readonly Color Khaki;

	[Cpp2IlInjected.Token(Token = "0x4001E94")]
	public static readonly Color Lavender;

	[Cpp2IlInjected.Token(Token = "0x4001E95")]
	public static readonly Color LavenderBlush;

	[Cpp2IlInjected.Token(Token = "0x4001E96")]
	public static readonly Color LawnGreen;

	[Cpp2IlInjected.Token(Token = "0x4001E97")]
	public static readonly Color LemonChiffon;

	[Cpp2IlInjected.Token(Token = "0x4001E98")]
	public static readonly Color LightBlue;

	[Cpp2IlInjected.Token(Token = "0x4001E99")]
	public static readonly Color LightCoral;

	[Cpp2IlInjected.Token(Token = "0x4001E9A")]
	public static readonly Color LightCyan;

	[Cpp2IlInjected.Token(Token = "0x4001E9B")]
	public static readonly Color LightGoldenrodYellow;

	[Cpp2IlInjected.Token(Token = "0x4001E9C")]
	public static readonly Color LightGreen;

	[Cpp2IlInjected.Token(Token = "0x4001E9D")]
	public static readonly Color LightGray;

	[Cpp2IlInjected.Token(Token = "0x4001E9E")]
	public static readonly Color LightPink;

	[Cpp2IlInjected.Token(Token = "0x4001E9F")]
	public static readonly Color LightSalmon;

	[Cpp2IlInjected.Token(Token = "0x4001EA0")]
	public static readonly Color LightSeaGreen;

	[Cpp2IlInjected.Token(Token = "0x4001EA1")]
	public static readonly Color LightSkyBlue;

	[Cpp2IlInjected.Token(Token = "0x4001EA2")]
	public static readonly Color LightSlateGray;

	[Cpp2IlInjected.Token(Token = "0x4001EA3")]
	public static readonly Color LightSteelBlue;

	[Cpp2IlInjected.Token(Token = "0x4001EA4")]
	public static readonly Color LightYellow;

	[Cpp2IlInjected.Token(Token = "0x4001EA5")]
	public static readonly Color Lime;

	[Cpp2IlInjected.Token(Token = "0x4001EA6")]
	public static readonly Color LimeGreen;

	[Cpp2IlInjected.Token(Token = "0x4001EA7")]
	public static readonly Color Linen;

	[Cpp2IlInjected.Token(Token = "0x4001EA8")]
	public static readonly Color Magenta;

	[Cpp2IlInjected.Token(Token = "0x4001EA9")]
	public static readonly Color Maroon;

	[Cpp2IlInjected.Token(Token = "0x4001EAA")]
	public static readonly Color MediumAquamarine;

	[Cpp2IlInjected.Token(Token = "0x4001EAB")]
	public static readonly Color MediumBlue;

	[Cpp2IlInjected.Token(Token = "0x4001EAC")]
	public static readonly Color MediumOrchid;

	[Cpp2IlInjected.Token(Token = "0x4001EAD")]
	public static readonly Color MediumPurple;

	[Cpp2IlInjected.Token(Token = "0x4001EAE")]
	public static readonly Color MediumSeaGreen;

	[Cpp2IlInjected.Token(Token = "0x4001EAF")]
	public static readonly Color MediumSlateBlue;

	[Cpp2IlInjected.Token(Token = "0x4001EB0")]
	public static readonly Color MediumSpringGreen;

	[Cpp2IlInjected.Token(Token = "0x4001EB1")]
	public static readonly Color MediumTurquoise;

	[Cpp2IlInjected.Token(Token = "0x4001EB2")]
	public static readonly Color MediumVioletRed;

	[Cpp2IlInjected.Token(Token = "0x4001EB3")]
	public static readonly Color MidnightBlue;

	[Cpp2IlInjected.Token(Token = "0x4001EB4")]
	public static readonly Color MintCream;

	[Cpp2IlInjected.Token(Token = "0x4001EB5")]
	public static readonly Color MistyRose;

	[Cpp2IlInjected.Token(Token = "0x4001EB6")]
	public static readonly Color Moccasin;

	[Cpp2IlInjected.Token(Token = "0x4001EB7")]
	public static readonly Color NavajoWhite;

	[Cpp2IlInjected.Token(Token = "0x4001EB8")]
	public static readonly Color Navy;

	[Cpp2IlInjected.Token(Token = "0x4001EB9")]
	public static readonly Color OldLace;

	[Cpp2IlInjected.Token(Token = "0x4001EBA")]
	public static readonly Color Olive;

	[Cpp2IlInjected.Token(Token = "0x4001EBB")]
	public static readonly Color OliveDrab;

	[Cpp2IlInjected.Token(Token = "0x4001EBC")]
	public static readonly Color Orange;

	[Cpp2IlInjected.Token(Token = "0x4001EBD")]
	public static readonly Color OrangeRed;

	[Cpp2IlInjected.Token(Token = "0x4001EBE")]
	public static readonly Color Orchid;

	[Cpp2IlInjected.Token(Token = "0x4001EBF")]
	public static readonly Color PaleGoldenrod;

	[Cpp2IlInjected.Token(Token = "0x4001EC0")]
	public static readonly Color PaleGreen;

	[Cpp2IlInjected.Token(Token = "0x4001EC1")]
	public static readonly Color PaleTurquoise;

	[Cpp2IlInjected.Token(Token = "0x4001EC2")]
	public static readonly Color PaleVioletRed;

	[Cpp2IlInjected.Token(Token = "0x4001EC3")]
	public static readonly Color PapayaWhip;

	[Cpp2IlInjected.Token(Token = "0x4001EC4")]
	public static readonly Color PeachPuff;

	[Cpp2IlInjected.Token(Token = "0x4001EC5")]
	public static readonly Color Peru;

	[Cpp2IlInjected.Token(Token = "0x4001EC6")]
	public static readonly Color Pink;

	[Cpp2IlInjected.Token(Token = "0x4001EC7")]
	public static readonly Color Plum;

	[Cpp2IlInjected.Token(Token = "0x4001EC8")]
	public static readonly Color PowderBlue;

	[Cpp2IlInjected.Token(Token = "0x4001EC9")]
	public static readonly Color Purple;

	[Cpp2IlInjected.Token(Token = "0x4001ECA")]
	public static readonly Color Red;

	[Cpp2IlInjected.Token(Token = "0x4001ECB")]
	public static readonly Color RosyBrown;

	[Cpp2IlInjected.Token(Token = "0x4001ECC")]
	public static readonly Color RoyalBlue;

	[Cpp2IlInjected.Token(Token = "0x4001ECD")]
	public static readonly Color SaddleBrown;

	[Cpp2IlInjected.Token(Token = "0x4001ECE")]
	public static readonly Color Salmon;

	[Cpp2IlInjected.Token(Token = "0x4001ECF")]
	public static readonly Color SandyBrown;

	[Cpp2IlInjected.Token(Token = "0x4001ED0")]
	public static readonly Color SeaGreen;

	[Cpp2IlInjected.Token(Token = "0x4001ED1")]
	public static readonly Color SeaShell;

	[Cpp2IlInjected.Token(Token = "0x4001ED2")]
	public static readonly Color Sienna;

	[Cpp2IlInjected.Token(Token = "0x4001ED3")]
	public static readonly Color Silver;

	[Cpp2IlInjected.Token(Token = "0x4001ED4")]
	public static readonly Color SkyBlue;

	[Cpp2IlInjected.Token(Token = "0x4001ED5")]
	public static readonly Color SlateBlue;

	[Cpp2IlInjected.Token(Token = "0x4001ED6")]
	public static readonly Color SlateGray;

	[Cpp2IlInjected.Token(Token = "0x4001ED7")]
	public static readonly Color Snow;

	[Cpp2IlInjected.Token(Token = "0x4001ED8")]
	public static readonly Color SpringGreen;

	[Cpp2IlInjected.Token(Token = "0x4001ED9")]
	public static readonly Color SteelBlue;

	[Cpp2IlInjected.Token(Token = "0x4001EDA")]
	public static readonly Color Tan;

	[Cpp2IlInjected.Token(Token = "0x4001EDB")]
	public static readonly Color Teal;

	[Cpp2IlInjected.Token(Token = "0x4001EDC")]
	public static readonly Color Thistle;

	[Cpp2IlInjected.Token(Token = "0x4001EDD")]
	public static readonly Color Tomato;

	[Cpp2IlInjected.Token(Token = "0x4001EDE")]
	public static readonly Color Turquoise;

	[Cpp2IlInjected.Token(Token = "0x4001EDF")]
	public static readonly Color Violet;

	[Cpp2IlInjected.Token(Token = "0x4001EE0")]
	public static readonly Color Wheat;

	[Cpp2IlInjected.Token(Token = "0x4001EE1")]
	public static readonly Color White;

	[Cpp2IlInjected.Token(Token = "0x4001EE2")]
	public static readonly Color WhiteSmoke;

	[Cpp2IlInjected.Token(Token = "0x4001EE3")]
	public static readonly Color Yellow;

	[Cpp2IlInjected.Token(Token = "0x4001EE4")]
	public static readonly Color YellowGreen;

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public uint PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001543")]
		[Cpp2IlInjected.Address(RVA = "0x39E890", Offset = "0x39E890", VA = "0x39E890")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6001544")]
		[Cpp2IlInjected.Address(RVA = "0x39E89C", Offset = "0x39E89C", VA = "0x39E89C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001538")]
	[Cpp2IlInjected.Address(RVA = "0x39E724", Offset = "0x39E724", VA = "0x39E724")]
	public Color(Vector3 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001539")]
	[Cpp2IlInjected.Address(RVA = "0x39E740", Offset = "0x39E740", VA = "0x39E740")]
	public Color(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600153A")]
	[Cpp2IlInjected.Address(RVA = "0x39E764", Offset = "0x39E764", VA = "0x39E764")]
	public Color(int r, int g, int b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600153B")]
	[Cpp2IlInjected.Address(RVA = "0x39E77C", Offset = "0x39E77C", VA = "0x39E77C")]
	public Color(int r, int g, int b, int a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600153C")]
	[Cpp2IlInjected.Address(RVA = "0x39E794", Offset = "0x39E794", VA = "0x39E794")]
	public Color(float r, float g, float b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600153D")]
	[Cpp2IlInjected.Address(RVA = "0x39E7B0", Offset = "0x39E7B0", VA = "0x39E7B0")]
	public Color(float r, float g, float b, float a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600153E")]
	[Cpp2IlInjected.Address(RVA = "0x39E7D4", Offset = "0x39E7D4", VA = "0x39E7D4")]
	public Color(Color rgb, int a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600153F")]
	[Cpp2IlInjected.Address(RVA = "0x39E7F4", Offset = "0x39E7F4", VA = "0x39E7F4")]
	public Color(Color rgb, float a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001540")]
	[Cpp2IlInjected.Address(RVA = "0x39E7FC", Offset = "0x39E7FC", VA = "0x39E7FC")]
	public ushort RGB565()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6001541")]
	[Cpp2IlInjected.Address(RVA = "0x39E820", Offset = "0x39E820", VA = "0x39E820")]
	public ushort ARGB4444()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6001542")]
	[Cpp2IlInjected.Address(RVA = "0x39E850", Offset = "0x39E850", VA = "0x39E850")]
	public Color32 RenderColour()
	{
		return default(Color32);
	}

	[Cpp2IlInjected.Token(Token = "0x6001545")]
	[Cpp2IlInjected.Address(RVA = "0x13984D8", Offset = "0x13984D8", VA = "0x13984D8")]
	public static bool operator ==(Color colorA, Color colorB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001546")]
	[Cpp2IlInjected.Address(RVA = "0x139852C", Offset = "0x139852C", VA = "0x139852C")]
	public static bool operator !=(Color colorA, Color colorB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001547")]
	[Cpp2IlInjected.Address(RVA = "0x39E8BC", Offset = "0x39E8BC", VA = "0x39E8BC")]
	internal float GetBrightness()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001548")]
	[Cpp2IlInjected.Address(RVA = "0x39E8C4", Offset = "0x39E8C4", VA = "0x39E8C4")]
	internal float GetSaturation()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001549")]
	[Cpp2IlInjected.Address(RVA = "0x39E8CC", Offset = "0x39E8CC", VA = "0x39E8CC")]
	internal float GetHue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600154A")]
	[Cpp2IlInjected.Address(RVA = "0x39E8D4", Offset = "0x39E8D4", VA = "0x39E8D4", Slot = "0")]
	public override bool Equals(object o)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600154B")]
	[Cpp2IlInjected.Address(RVA = "0x39E8DC", Offset = "0x39E8DC", VA = "0x39E8DC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600154C")]
	[Cpp2IlInjected.Address(RVA = "0x39E900", Offset = "0x39E900", VA = "0x39E900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600154D")]
	[Cpp2IlInjected.Address(RVA = "0x39E908", Offset = "0x39E908", VA = "0x39E908")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600154E")]
	[Cpp2IlInjected.Address(RVA = "0x39E91C", Offset = "0x39E91C", VA = "0x39E91C")]
	public Vector3 ToVector3()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600154F")]
	[Cpp2IlInjected.Address(RVA = "0x1398CA0", Offset = "0x1398CA0", VA = "0x1398CA0")]
	public static Color operator *(Color a, float amount)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001550")]
	[Cpp2IlInjected.Address(RVA = "0x1398D58", Offset = "0x1398D58", VA = "0x1398D58")]
	public static Color Multiply(Color a, float amount)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001551")]
	[Cpp2IlInjected.Address(RVA = "0x1398DD8", Offset = "0x1398DD8", VA = "0x1398DD8")]
	public static Color Lerp(Color value1, Color value2, float amount)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001552")]
	[Cpp2IlInjected.Address(RVA = "0x39E98C", Offset = "0x39E98C", VA = "0x39E98C", Slot = "4")]
	public bool Equals(Color other)
	{
		return default(bool);
	}
}
