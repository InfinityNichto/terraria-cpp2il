using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x02000232 RID: 562
[global::Cpp2ILInjected.Token(Token = "0x20002E6")]
public class TextureAtlasDB
{
	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00024A73 File Offset: 0x00022C73
	[global::Cpp2ILInjected.Token(Token = "0x17000197")]
	public static bool DefaultTexturesHigh
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001124")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6814C", Offset = "0xA6814C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadTextureDBs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowMemoryPopup), Member = "get_DeviceMemory", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x00024A76 File Offset: 0x00022C76
	[global::Cpp2ILInjected.Token(Token = "0x6001125")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6817C", Offset = "0xA6817C", Length = "0x19C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "initialiseCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "get_DefaultTexturesHigh", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "LoadDB", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(TextureAtlasDB))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void LoadTextureDBs()
	{
		throw null;
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x00024A79 File Offset: 0x00022C79
	[global::Cpp2ILInjected.Token(Token = "0x6001126")]
	[global::Cpp2ILInjected.Address(RVA = "0xA68388", Offset = "0xA68388", Length = "0x160")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadTexture2D", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UID), Member = "Generate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "GetTexture", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref TextureAtlasDB),
		typeof(ref TextureAtlasEntry)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public static bool LoadTexture(string file, out TextureAtlasDB atlas, out TextureAtlasEntry atlasEntry)
	{
		throw null;
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00024A7C File Offset: 0x00022C7C
	[global::Cpp2ILInjected.Token(Token = "0x17000198")]
	private string ContentRoot
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001127")]
		[global::Cpp2ILInjected.Address(RVA = "0xA68574", Offset = "0xA68574", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadTexturesAsync", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "AltlasTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::UnityEngine.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00024A7F File Offset: 0x00022C7F
	[global::Cpp2ILInjected.Token(Token = "0x6001128")]
	[global::Cpp2ILInjected.Address(RVA = "0xA68318", Offset = "0xA68318", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadTextureDBs", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "Load", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private static TextureAtlasDB LoadDB(string id, bool useLowResTextures = false)
	{
		throw null;
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x00024A82 File Offset: 0x00022C82
	[global::Cpp2ILInjected.Token(Token = "0x6001129")]
	[global::Cpp2ILInjected.Address(RVA = "0xA685E0", Offset = "0xA685E0", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadDB", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(TextureAtlasDB))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public TextureAtlasDB(string id)
	{
		throw null;
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x00024A85 File Offset: 0x00022C85
	[global::Cpp2ILInjected.Token(Token = "0x600112A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA68C60", Offset = "0xA68C60", Length = "0x22C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "Load", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "UnloadAsset", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "GetBatchId", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public void SetNumberOfAtlasPages(short pages)
	{
		throw null;
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00024A88 File Offset: 0x00022C88
	[global::Cpp2ILInjected.Token(Token = "0x600112B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA68E8C", Offset = "0xA68E8C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "AltlasTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::UnityEngine.Texture2D))]
	private void LoadTextures()
	{
		throw null;
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00024A8B File Offset: 0x00022C8B
	[global::Cpp2ILInjected.Token(Token = "0x600112C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA69178", Offset = "0xA69178", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "Load", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void AddEntry(TextureAtlasEntry entry)
	{
		throw null;
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00024A8E File Offset: 0x00022C8E
	[global::Cpp2ILInjected.Token(Token = "0x600112D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA68670", Offset = "0xA68670", Length = "0x5F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadDB", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(TextureAtlasDB))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "ActionPendingUnloadAssets", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "get_ContentRoot", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadUnityResource", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "ResourceType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_bytes", ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "SetNumberOfAtlasPages", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasEntry), Member = "LoadData", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(short)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasEntry), Member = "Load", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(short)
	}, ReturnType = typeof(TextureAtlasEntry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "AddEntry", MemberParameters = new object[] { typeof(TextureAtlasEntry) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
	public void Load()
	{
		throw null;
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00024A91 File Offset: 0x00022C91
	[global::Cpp2ILInjected.Token(Token = "0x600112E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA69440", Offset = "0xA69440", Length = "0x55C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection), Member = "get_Count", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasEntry), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	public byte[] Save()
	{
		throw null;
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00024A94 File Offset: 0x00022C94
	[global::Cpp2ILInjected.Token(Token = "0x600112F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA69B08", Offset = "0xA69B08", Length = "0x230")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "RefreshAtlasTexture", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	private void LoadCallback(global::UnityEngine.Texture2D tex0, global::UnityEngine.Texture2D tex1, global::UnityEngine.Texture2D tex2, int page)
	{
		throw null;
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00024A97 File Offset: 0x00022C97
	[global::Cpp2ILInjected.Token(Token = "0x6001130")]
	[global::Cpp2ILInjected.Address(RVA = "0xA69D38", Offset = "0xA69D38", Length = "0x1C4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "get_ContentRoot", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<, , , >), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadUnityTexturePageAsync", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(int),
		typeof(Action<global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, int>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void LoadTexturesAsync(int index)
	{
		throw null;
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x00024A9A File Offset: 0x00022C9A
	[global::Cpp2ILInjected.Token(Token = "0x6001131")]
	[global::Cpp2ILInjected.Address(RVA = "0xA68ED8", Offset = "0xA68ED8", Length = "0x2A0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadTextures", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "RefreshAtlasTexture", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "get_ContentRoot", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadUnityResource", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "ResourceType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public global::UnityEngine.Texture2D AltlasTexture(int index)
	{
		throw null;
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x00024A9D File Offset: 0x00022C9D
	[global::Cpp2ILInjected.Token(Token = "0x6001132")]
	[global::Cpp2ILInjected.Address(RVA = "0xA69EFC", Offset = "0xA69EFC", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "RefreshAtlasTexture", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public global::UnityEngine.Texture2D AltlasAlphaTexture(int index)
	{
		throw null;
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00024AA0 File Offset: 0x00022CA0
	[global::Cpp2ILInjected.Token(Token = "0x6001133")]
	[global::Cpp2ILInjected.Address(RVA = "0xA69F0C", Offset = "0xA69F0C", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "RefreshAtlasTexture", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public global::UnityEngine.Texture2D AltlasPalTexture(int index)
	{
		throw null;
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00024AA3 File Offset: 0x00022CA3
	[global::Cpp2ILInjected.Token(Token = "0x6001134")]
	[global::Cpp2ILInjected.Address(RVA = "0xA684E8", Offset = "0xA684E8", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadTexture", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref TextureAtlasDB),
		typeof(ref TextureAtlasEntry)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public bool GetTexture(int fileUID, out TextureAtlasDB atlas, out TextureAtlasEntry atlasEntry)
	{
		throw null;
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00024AA6 File Offset: 0x00022CA6
	[global::Cpp2ILInjected.Token(Token = "0x6001135")]
	[global::Cpp2ILInjected.Address(RVA = "0xA69F1C", Offset = "0xA69F1C", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "set_UITexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "set_CharacterTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "set_ProjectileTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "set_BackgroundTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "set_GoreTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "set_GlowTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "set_EnvironmentTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private static void SwitchAtlas(int atlas, bool useLowRes)
	{
		throw null;
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000FED RID: 4077 RVA: 0x00024AA9 File Offset: 0x00022CA9
	// (set) Token: 0x06000FEE RID: 4078 RVA: 0x00024AAC File Offset: 0x00022CAC
	[global::Cpp2ILInjected.Token(Token = "0x17000199")]
	public static bool UITexturesHigh
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001136")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A044", Offset = "0xA6A044", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001137")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A09C", Offset = "0xA6A09C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "SwitchAtlas", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00024AAF File Offset: 0x00022CAF
	// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00024AB2 File Offset: 0x00022CB2
	[global::Cpp2ILInjected.Token(Token = "0x1700019A")]
	public static bool CharacterTexturesHigh
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001138")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A158", Offset = "0xA6A158", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001139")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A1B0", Offset = "0xA6A1B0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "SwitchAtlas", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00024AB5 File Offset: 0x00022CB5
	// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00024AB8 File Offset: 0x00022CB8
	[global::Cpp2ILInjected.Token(Token = "0x1700019B")]
	public static bool ProjectileTexturesHigh
	{
		[global::Cpp2ILInjected.Token(Token = "0x600113A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A254", Offset = "0xA6A254", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600113B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A2AC", Offset = "0xA6A2AC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "SwitchAtlas", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00024ABB File Offset: 0x00022CBB
	// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00024ABE File Offset: 0x00022CBE
	[global::Cpp2ILInjected.Token(Token = "0x1700019C")]
	public static bool BackgroundTexturesHigh
	{
		[global::Cpp2ILInjected.Token(Token = "0x600113C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A340", Offset = "0xA6A340", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600113D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A398", Offset = "0xA6A398", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "SwitchAtlas", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00024AC1 File Offset: 0x00022CC1
	// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00024AC4 File Offset: 0x00022CC4
	[global::Cpp2ILInjected.Token(Token = "0x1700019D")]
	public static bool GoreTexturesHigh
	{
		[global::Cpp2ILInjected.Token(Token = "0x600113E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A448", Offset = "0xA6A448", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600113F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A4A0", Offset = "0xA6A4A0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "SwitchAtlas", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00024AC7 File Offset: 0x00022CC7
	// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00024ACA File Offset: 0x00022CCA
	[global::Cpp2ILInjected.Token(Token = "0x1700019E")]
	public static bool GlowTexturesHigh
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001140")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A534", Offset = "0xA6A534", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001141")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A58C", Offset = "0xA6A58C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "SwitchAtlas", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00024ACD File Offset: 0x00022CCD
	// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00024AD0 File Offset: 0x00022CD0
	[global::Cpp2ILInjected.Token(Token = "0x1700019F")]
	public static bool EnvironmentTexturesHigh
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001142")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A620", Offset = "0xA6A620", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001143")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6A678", Offset = "0xA6A678", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "SwitchAtlas", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x00024AD3 File Offset: 0x00022CD3
	[global::Cpp2ILInjected.Token(Token = "0x6001144")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6A734", Offset = "0xA6A734", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static bool PendingAssetUnload()
	{
		throw null;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00024AD6 File Offset: 0x00022CD6
	[global::Cpp2ILInjected.Token(Token = "0x6001145")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6A7C4", Offset = "0xA6A7C4", Length = "0x260")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Application_lowMemory", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TextureAtlasDB.SwitchEntry>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "Load", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "DestroyMaterials", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "UnloadSourceTextures", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public static void ActionPendingUnloadAssets(bool fromLowMemory = false)
	{
		throw null;
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00024AD9 File Offset: 0x00022CD9
	[global::Cpp2ILInjected.Token(Token = "0x6001146")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6AA24", Offset = "0xA6AA24", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Application_lowMemory", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ResetSettings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void UnloadAssets()
	{
		throw null;
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x00024ADC File Offset: 0x00022CDC
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6001147")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6AA80", Offset = "0xA6AA80", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TextureAtlasDB.SwitchEntry>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	static TextureAtlasDB()
	{
		throw null;
	}

	// Token: 0x04001B56 RID: 6998
	[global::Cpp2ILInjected.Token(Token = "0x40020EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int[] BatchTextureIndex;

	// Token: 0x04001B57 RID: 6999
	[global::Cpp2ILInjected.Token(Token = "0x40020EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int[] TextureWidth;

	// Token: 0x04001B58 RID: 7000
	[global::Cpp2ILInjected.Token(Token = "0x40020EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int[] TextureHeight;

	// Token: 0x04001B59 RID: 7001
	[global::Cpp2ILInjected.Token(Token = "0x40020ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool UseLowResTextures;

	// Token: 0x04001B5A RID: 7002
	[global::Cpp2ILInjected.Token(Token = "0x40020EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
	private short NumberOfPages;

	// Token: 0x04001B5B RID: 7003
	[global::Cpp2ILInjected.Token(Token = "0x40020EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private string Id;

	// Token: 0x04001B5C RID: 7004
	[global::Cpp2ILInjected.Token(Token = "0x40020F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private bool loaded;

	// Token: 0x04001B5D RID: 7005
	[global::Cpp2ILInjected.Token(Token = "0x40020F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private bool[] TexturesLoadRequested;

	// Token: 0x04001B5E RID: 7006
	[global::Cpp2ILInjected.Token(Token = "0x40020F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::UnityEngine.Texture2D[] Textures;

	// Token: 0x04001B5F RID: 7007
	[global::Cpp2ILInjected.Token(Token = "0x40020F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private global::UnityEngine.Texture2D[] TexturesAlpha;

	// Token: 0x04001B60 RID: 7008
	[global::Cpp2ILInjected.Token(Token = "0x40020F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private global::UnityEngine.Texture2D[] TexturesPal;

	// Token: 0x04001B61 RID: 7009
	[global::Cpp2ILInjected.Token(Token = "0x40020F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private Dictionary<int, TextureAtlasEntry> AtlasEntries;

	// Token: 0x04001B62 RID: 7010
	[global::Cpp2ILInjected.Token(Token = "0x40020F6")]
	public static List<TextureAtlasDB> AltlasDBs;

	// Token: 0x04001B63 RID: 7011
	[global::Cpp2ILInjected.Token(Token = "0x40020F7")]
	private static bool _uiTexturesHigh;

	// Token: 0x04001B64 RID: 7012
	[global::Cpp2ILInjected.Token(Token = "0x40020F8")]
	private static bool _characterTexturesHigh;

	// Token: 0x04001B65 RID: 7013
	[global::Cpp2ILInjected.Token(Token = "0x40020F9")]
	private static bool _projectileTexturesHigh;

	// Token: 0x04001B66 RID: 7014
	[global::Cpp2ILInjected.Token(Token = "0x40020FA")]
	private static bool _backgroundTexturesHigh;

	// Token: 0x04001B67 RID: 7015
	[global::Cpp2ILInjected.Token(Token = "0x40020FB")]
	private static bool _goreTexturesHigh;

	// Token: 0x04001B68 RID: 7016
	[global::Cpp2ILInjected.Token(Token = "0x40020FC")]
	private static bool _glowTexturesHigh;

	// Token: 0x04001B69 RID: 7017
	[global::Cpp2ILInjected.Token(Token = "0x40020FD")]
	private static bool _environmentTexturesHigh;

	// Token: 0x04001B6A RID: 7018
	[global::Cpp2ILInjected.Token(Token = "0x40020FE")]
	private static List<TextureAtlasDB.SwitchEntry> pendingSwitches;

	// Token: 0x04001B6B RID: 7019
	[global::Cpp2ILInjected.Token(Token = "0x40020FF")]
	private static bool PendingUnload;

	// Token: 0x02000813 RID: 2067
	[global::Cpp2ILInjected.Token(Token = "0x20002E7")]
	public enum AtlasIds
	{
		// Token: 0x04007D53 RID: 32083
		[global::Cpp2ILInjected.Token(Token = "0x4002101")]
		Tiles,
		// Token: 0x04007D54 RID: 32084
		[global::Cpp2ILInjected.Token(Token = "0x4002102")]
		Misc,
		// Token: 0x04007D55 RID: 32085
		[global::Cpp2ILInjected.Token(Token = "0x4002103")]
		NPC,
		// Token: 0x04007D56 RID: 32086
		[global::Cpp2ILInjected.Token(Token = "0x4002104")]
		Walls,
		// Token: 0x04007D57 RID: 32087
		[global::Cpp2ILInjected.Token(Token = "0x4002105")]
		Waterfall,
		// Token: 0x04007D58 RID: 32088
		[global::Cpp2ILInjected.Token(Token = "0x4002106")]
		Trees,
		// Token: 0x04007D59 RID: 32089
		[global::Cpp2ILInjected.Token(Token = "0x4002107")]
		Player,
		// Token: 0x04007D5A RID: 32090
		[global::Cpp2ILInjected.Token(Token = "0x4002108")]
		Item,
		// Token: 0x04007D5B RID: 32091
		[global::Cpp2ILInjected.Token(Token = "0x4002109")]
		Projectile,
		// Token: 0x04007D5C RID: 32092
		[global::Cpp2ILInjected.Token(Token = "0x400210A")]
		Gore,
		// Token: 0x04007D5D RID: 32093
		[global::Cpp2ILInjected.Token(Token = "0x400210B")]
		Glow,
		// Token: 0x04007D5E RID: 32094
		[global::Cpp2ILInjected.Token(Token = "0x400210C")]
		MapBG,
		// Token: 0x04007D5F RID: 32095
		[global::Cpp2ILInjected.Token(Token = "0x400210D")]
		UI,
		// Token: 0x04007D60 RID: 32096
		[global::Cpp2ILInjected.Token(Token = "0x400210E")]
		Buff,
		// Token: 0x04007D61 RID: 32097
		[global::Cpp2ILInjected.Token(Token = "0x400210F")]
		MiniMap,
		// Token: 0x04007D62 RID: 32098
		[global::Cpp2ILInjected.Token(Token = "0x4002110")]
		Background,
		// Token: 0x04007D63 RID: 32099
		[global::Cpp2ILInjected.Token(Token = "0x4002111")]
		Count
	}

	// Token: 0x02000814 RID: 2068
	[global::Cpp2ILInjected.Token(Token = "0x20002E8")]
	private struct SwitchEntry
	{
		// Token: 0x04007D64 RID: 32100
		[global::Cpp2ILInjected.Token(Token = "0x4002112")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int atlas;

		// Token: 0x04007D65 RID: 32101
		[global::Cpp2ILInjected.Token(Token = "0x4002113")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool useLowRes;
	}
}
