using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000575")]
public class VanillaContentValidator : IContentValidator
{
	[Cpp2IlInjected.Token(Token = "0x2000997")]
	private struct TextureMetaData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008C79")]
		public int Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008C7A")]
		public int Height;

		[Cpp2IlInjected.Token(Token = "0x6004E1F")]
		[Cpp2IlInjected.Address(RVA = "0x399F00", Offset = "0x399F00", VA = "0x399F00")]
		public bool Matches(Texture2D texture, out IRejectionReason rejectReason)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006AC4")]
	public static VanillaContentValidator Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006AC5")]
	private Dictionary<string, TextureMetaData> _info;

	[Cpp2IlInjected.Token(Token = "0x6003AFC")]
	[Cpp2IlInjected.Address(RVA = "0xE15A00", Offset = "0xE15A00", VA = "0xE15A00")]
	public VanillaContentValidator(string infoFilePath)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AFD")]
	[Cpp2IlInjected.Address(RVA = "0x1760950", Offset = "0x1760950", VA = "0x1760950", Slot = "4")]
	public bool AssetIsValid<T>(T content, string contentPath, out IRejectionReason rejectReason) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AFE")]
	[Cpp2IlInjected.Address(RVA = "0xE15C20", Offset = "0xE15C20", VA = "0xE15C20")]
	public HashSet<string> GetValidImageFilePaths()
	{
		return null;
	}
}
