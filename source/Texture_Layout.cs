using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;

// Token: 0x02000141 RID: 321
[JsonObject(MemberSerialization.OptIn)]
[global::Cpp2ILInjected.Token(Token = "0x20001C2")]
[Serializable]
public class Texture_Layout
{
	// Token: 0x06000ACE RID: 2766 RVA: 0x00023BAF File Offset: 0x00021DAF
	[global::Cpp2ILInjected.Token(Token = "0x6000BDD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B4B70", Offset = "0x9B4B70", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PVPIcons_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Texture_Layout()
	{
		throw null;
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x00023BB2 File Offset: 0x00021DB2
	[global::Cpp2ILInjected.Token(Token = "0x6000BDE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B27FC", Offset = "0x9B27FC", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawControl", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(ControlsBanner_Layout.ControlGroupingPosition),
		typeof(Vector2),
		typeof(GUIControlsBanner.Action),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Copy(Texture_Layout other)
	{
		throw null;
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x00023BB5 File Offset: 0x00021DB5
	[global::Cpp2ILInjected.Token(Token = "0x6000BDF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AEA68", Offset = "0x9AEA68", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FavoriteIcons), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MultiplayerLobby), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SelectPlayerFavoriteIcons), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SelectWorldFavoriteIcons), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Reforge_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResearchPage_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RubbleMakerUI_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Texture_Layout(string defaultTextureId)
	{
		throw null;
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00023BB8 File Offset: 0x00021DB8
	[global::Cpp2ILInjected.Token(Token = "0x6000BE0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B4B78", Offset = "0x9B4B78", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Write(BinaryWriter writer)
	{
		throw null;
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00023BBB File Offset: 0x00021DBB
	[global::Cpp2ILInjected.Token(Token = "0x6000BE1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B4B94", Offset = "0x9B4B94", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Load(int version, BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00023BBE File Offset: 0x00021DBE
	[global::Cpp2ILInjected.Token(Token = "0x17000145")]
	public Texture2D Texture
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B4BBC", Offset = "0x9B4BBC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 256)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x00023BC1 File Offset: 0x00021DC1
	[global::Cpp2ILInjected.Token(Token = "0x6000BE3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B4D00", Offset = "0x9B4D00", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void Setup(ContentManager manager)
	{
		throw null;
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00023BC4 File Offset: 0x00021DC4
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000BE4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B4D5C", Offset = "0x9B4D5C", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	static Texture_Layout()
	{
		throw null;
	}

	// Token: 0x04000B48 RID: 2888
	[JsonProperty]
	[global::Cpp2ILInjected.Token(Token = "0x4000F38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string TextureId;

	// Token: 0x04000B49 RID: 2889
	[global::Cpp2ILInjected.Token(Token = "0x4000F39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Texture2D _texture;

	// Token: 0x04000B4A RID: 2890
	[global::Cpp2ILInjected.Token(Token = "0x4000F3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string _lastTextureId;

	// Token: 0x04000B4B RID: 2891
	[global::Cpp2ILInjected.Token(Token = "0x4000F3B")]
	private static ContentManager _contentManager;

	// Token: 0x04000B4C RID: 2892
	[global::Cpp2ILInjected.Token(Token = "0x4000F3C")]
	private static Dictionary<string, Texture2D> _textureDictionary;
}
