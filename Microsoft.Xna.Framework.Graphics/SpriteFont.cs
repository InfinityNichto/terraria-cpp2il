using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002C9")]
public sealed class SpriteFont
{
	[Cpp2IlInjected.Token(Token = "0x2000822")]
	internal static class Errors
	{
		[Cpp2IlInjected.Token(Token = "0x4007DF4")]
		public const string TextContainsUnresolvableCharacters = "Text contains characters that cannot be resolved by this SpriteFont.";

		[Cpp2IlInjected.Token(Token = "0x4007DF5")]
		public const string UnresolvableCharacter = "Character cannot be resolved by this SpriteFont.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000823")]
	private class CharComparer : IEqualityComparer<char>
	{
		[Cpp2IlInjected.Token(Token = "0x4007DF6")]
		public static readonly CharComparer Default;

		[Cpp2IlInjected.Token(Token = "0x6004979")]
		[Cpp2IlInjected.Address(RVA = "0x154B3D8", Offset = "0x154B3D8", VA = "0x154B3D8", Slot = "4")]
		public bool Equals(char x, char y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600497A")]
		[Cpp2IlInjected.Address(RVA = "0x154B3E8", Offset = "0x154B3E8", VA = "0x154B3E8", Slot = "5")]
		public int GetHashCode(char b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600497B")]
		[Cpp2IlInjected.Address(RVA = "0x154B3F0", Offset = "0x154B3F0", VA = "0x154B3F0")]
		public CharComparer()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000824")]
	[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x3856E4", Offset = "0x3856E4")]
	public struct CharacterSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007DF7")]
		private readonly string _string;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007DF8")]
		private readonly int _stringOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007DF9")]
		private readonly StringBuilder _builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007DFA")]
		public readonly int Length;

		[Cpp2IlInjected.Token(Token = "0x1700084C")]
		public char Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004981")]
			[Cpp2IlInjected.Address(RVA = "0x3A09B0", Offset = "0x3A09B0", VA = "0x3A09B0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600497D")]
		[Cpp2IlInjected.Address(RVA = "0x3A0918", Offset = "0x3A0918", VA = "0x3A0918")]
		public CharacterSource(string s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600497E")]
		[Cpp2IlInjected.Address(RVA = "0x3A0934", Offset = "0x3A0934", VA = "0x3A0934")]
		public CharacterSource(string s, int startIndex, int endIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600497F")]
		[Cpp2IlInjected.Address(RVA = "0x3A0958", Offset = "0x3A0958", VA = "0x3A0958")]
		public CharacterSource(StringBuilder builder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004980")]
		[Cpp2IlInjected.Address(RVA = "0x3A0988", Offset = "0x3A0988", VA = "0x3A0988")]
		public CharacterSource(StringBuilder builder, int startIndex, int endIndex)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000825")]
	public struct Glyph
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007DFB")]
		public char Character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007DFC")]
		public Rectangle BoundsInTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007DFD")]
		public Rectangle Cropping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007DFE")]
		public float LeftSideBearing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007DFF")]
		public float RightSideBearing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007E00")]
		public float Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007E01")]
		public float WidthIncludingBearings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007E02")]
		public byte TexureIndex;

		[Cpp2IlInjected.Token(Token = "0x4007E03")]
		public static readonly Glyph Empty;

		[Cpp2IlInjected.Token(Token = "0x6004982")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A64", Offset = "0x3A0A64", VA = "0x3A0A64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000826")]
	private struct CharacterRegion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E04")]
		public char Start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4007E05")]
		public char End;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007E06")]
		public int StartIndex;

		[Cpp2IlInjected.Token(Token = "0x6004984")]
		[Cpp2IlInjected.Address(RVA = "0x3A0864", Offset = "0x3A0864", VA = "0x3A0864")]
		public CharacterRegion(char start, int startIndex)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002069")]
	private readonly Glyph[] _glyphs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400206A")]
	private Dictionary<char, int> _glyphIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400206B")]
	private char? _defaultCharacter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400206C")]
	private int _defaultGlyphIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400206D")]
	private readonly Texture2D[] _textures;

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public Glyph[] Glyphs
	{
		[Cpp2IlInjected.Token(Token = "0x6001722")]
		[Cpp2IlInjected.Address(RVA = "0x154A154", Offset = "0x154A154", VA = "0x154A154")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public Texture2D[] Textures
	{
		[Cpp2IlInjected.Token(Token = "0x6001725")]
		[Cpp2IlInjected.Address(RVA = "0x154A3E4", Offset = "0x154A3E4", VA = "0x154A3E4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public char? DefaultCharacter
	{
		[Cpp2IlInjected.Token(Token = "0x6001727")]
		[Cpp2IlInjected.Address(RVA = "0x154A584", Offset = "0x154A584", VA = "0x154A584")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001728")]
		[Cpp2IlInjected.Address(RVA = "0x154A2F4", Offset = "0x154A2F4", VA = "0x154A2F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public int LineSpacing
	{
		[Cpp2IlInjected.Token(Token = "0x6001729")]
		[Cpp2IlInjected.Address(RVA = "0x154A600", Offset = "0x154A600", VA = "0x154A600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600172A")]
		[Cpp2IlInjected.Address(RVA = "0x154A608", Offset = "0x154A608", VA = "0x154A608")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public float Spacing
	{
		[Cpp2IlInjected.Token(Token = "0x600172B")]
		[Cpp2IlInjected.Address(RVA = "0x154A610", Offset = "0x154A610", VA = "0x154A610")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600172C")]
		[Cpp2IlInjected.Address(RVA = "0x154A618", Offset = "0x154A618", VA = "0x154A618")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001723")]
	[Cpp2IlInjected.Address(RVA = "0x154A15C", Offset = "0x154A15C", VA = "0x154A15C")]
	public SpriteFont()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001724")]
	[Cpp2IlInjected.Address(RVA = "0x154A1E8", Offset = "0x154A1E8", VA = "0x154A1E8")]
	public SpriteFont(Texture2D[] textures, Glyph[] glyphs, int lineSpacing, float spacing, char? defaultCharacter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001726")]
	[Cpp2IlInjected.Address(RVA = "0x154A3EC", Offset = "0x154A3EC", VA = "0x154A3EC")]
	public Dictionary<char, Glyph> GetGlyphs()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600172D")]
	[Cpp2IlInjected.Address(RVA = "0x154A620", Offset = "0x154A620", VA = "0x154A620")]
	public Vector2 MeasureString(string text)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600172E")]
	[Cpp2IlInjected.Address(RVA = "0x154AB54", Offset = "0x154AB54", VA = "0x154AB54")]
	public int GetMaxCharacterIndex(string text, int startIndex, int endIndex, float scale, float maxWidth)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600172F")]
	[Cpp2IlInjected.Address(RVA = "0x154B000", Offset = "0x154B000", VA = "0x154B000")]
	public Vector2 MeasureString(string text, int startIndex, int endIndex)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001730")]
	[Cpp2IlInjected.Address(RVA = "0x154B054", Offset = "0x154B054", VA = "0x154B054")]
	public Vector2 MeasureString(StringBuilder text, int startIndex, int endIndex)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001731")]
	[Cpp2IlInjected.Address(RVA = "0x154B0D8", Offset = "0x154B0D8", VA = "0x154B0D8")]
	public Vector2 MeasureString(StringBuilder text)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001732")]
	[Cpp2IlInjected.Address(RVA = "0x154ABD0", Offset = "0x154ABD0", VA = "0x154ABD0")]
	internal void MeasureMaxString(ref CharacterSource text, out int lastCharacter, float maxWidth, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001733")]
	[Cpp2IlInjected.Address(RVA = "0x154A688", Offset = "0x154A688", VA = "0x154A688")]
	internal void MeasureString(ref CharacterSource text, out Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001734")]
	[Cpp2IlInjected.Address(RVA = "0x154A58C", Offset = "0x154A58C", VA = "0x154A58C")]
	internal bool TryGetGlyphIndex(char c, out int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001735")]
	[Cpp2IlInjected.Address(RVA = "0x154B278", Offset = "0x154B278", VA = "0x154B278")]
	public bool HasCharacter(char c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001736")]
	[Cpp2IlInjected.Address(RVA = "0x154B194", Offset = "0x154B194", VA = "0x154B194")]
	internal int GetGlyphIndexOrDefault(char c)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001737")]
	[Cpp2IlInjected.Address(RVA = "0x154B29C", Offset = "0x154B29C", VA = "0x154B29C")]
	public string CreateWrappedText(string text, float maxWidth)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001738")]
	[Cpp2IlInjected.Address(RVA = "0x154B2E0", Offset = "0x154B2E0", VA = "0x154B2E0")]
	public string CreateWrappedText(string text, float maxWidth, CultureInfo culture)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001739")]
	[Cpp2IlInjected.Address(RVA = "0x154B390", Offset = "0x154B390", VA = "0x154B390")]
	public Glyph GetCharacterMetrics(char character)
	{
		return default(Glyph);
	}
}
