using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000142")]
[JsonObject]
public class Texture_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000B51")]
	[JsonProperty]
	public string TextureId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000B52")]
	private Texture2D _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000B53")]
	private string _lastTextureId;

	[Cpp2IlInjected.Token(Token = "0x4000B54")]
	private static ContentManager _contentManager;

	[Cpp2IlInjected.Token(Token = "0x4000B55")]
	private static Dictionary<string, Texture2D> _textureDictionary;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Texture2D Texture
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x10CD154", Offset = "0x10CD154", VA = "0x10CD154")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x10CD0DC", Offset = "0x10CD0DC", VA = "0x10CD0DC")]
	public Texture_Layout()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x10CD0E4", Offset = "0x10CD0E4", VA = "0x10CD0E4")]
	public void Copy(Texture_Layout other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x10CD0F0", Offset = "0x10CD0F0", VA = "0x10CD0F0")]
	public Texture_Layout(string defaultTextureId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x10CD110", Offset = "0x10CD110", VA = "0x10CD110")]
	public void Write(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x10CD12C", Offset = "0x10CD12C", VA = "0x10CD12C")]
	public void Load(int version, BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x10CD2C0", Offset = "0x10CD2C0", VA = "0x10CD2C0")]
	public static void Setup(ContentManager manager)
	{
	}
}
