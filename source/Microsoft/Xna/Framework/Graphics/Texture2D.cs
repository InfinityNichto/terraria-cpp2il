using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria;
using Terraria.GameContent.Liquid;
using Terraria.Graphics;
using Terraria.Initializers;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x20003AA")]
	public class Texture2D : Texture
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001911")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC5F98", Offset = "0xAC5F98", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasEntry), Member = "LoadData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "UnloadSourceTextures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UnloadSplashScreenTextures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "UnloadAsset", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ResetLoaded()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034E")]
		public int UnityTextureWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001912")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC6128", Offset = "0xAC6128", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_UnityBindTexture", ReturnType = typeof(Texture))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001913")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC61EC", Offset = "0xAC61EC", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void LoadCallback(Texture2D tex0, Texture2D tex1, Texture2D tex2, int page)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001914")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC6324", Offset = "0xAC6324", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "get_UnityTexture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
			typeof(Action<Texture2D, Texture2D, Texture2D, int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void LoadSourceTexture()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034F")]
		public int UnityTextureHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001915")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC661C", Offset = "0xAC661C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_UnityBindTexture", ReturnType = typeof(Texture))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000350")]
		public Texture UnityBindTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001916")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC6170", Offset = "0xAC6170", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "OnRenderImage", MemberParameters = new object[]
			{
				typeof(RenderTexture),
				typeof(RenderTexture)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer.MaterialEntry), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(MaterialBuffer.MaterialPartition),
				typeof(List<MaterialBuffer.MaterialEntry>),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "GetMaterial", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "get_UnityTextureWidth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "get_UnityTextureHeight", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_UnityTexture", ReturnType = typeof(Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001917")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC676C", Offset = "0xAC676C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadCallback", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "AltlasTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "AltlasAlphaTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "AltlasPalTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Texture2D))]
		public void RefreshAtlasTexture()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000351")]
		public Texture2D UnityTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001918")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC6664", Offset = "0xAC6664", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "ClearMap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "ApplyMap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "CleanupMapTargets", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "ApplySection", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap_Section", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = "ApplyValuesToMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Material)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "get_UnityBindTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadTexture2D", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadBackground", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "SetWaveMaskData", MemberParameters = new object[] { typeof(ref Texture2D) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "LoadTexturesAsync", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "LoadSourceTexture", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "AltlasTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "AltlasAlphaTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "AltlasPalTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000352")]
		public Texture2D UnityAlphaTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001919")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC6808", Offset = "0xAC6808", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000353")]
		public Texture2D UnityPalTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x600191A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC6810", Offset = "0xAC6810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600191B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC6818", Offset = "0xAC6818", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "SetNumberOfAtlasPages", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int GetBatchId()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600191C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC60F0", Offset = "0xAC60F0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadWall", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadTextures_InSteps>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadTextures", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public void RefreshBatchIndex()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000354")]
		public Rectangle Bounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x600191D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC6868", Offset = "0xAC6868", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600191E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC689C", Offset = "0xAC689C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadTexture2D", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Texture2D(string sourceAsset, int width, int height)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600191F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC6B28", Offset = "0xAC6B28", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "InitialiseTargets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "CreateTextureAsset", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "CreateTextureAssets", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "SetWaveMaskData", MemberParameters = new object[] { typeof(ref Texture2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Texture2D(Texture2D texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001920")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC6BD4", Offset = "0xAC6BD4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Texture2D(RenderTexture texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001921")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC6C80", Offset = "0xAC6C80", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "CreateTextureAssets", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Texture2D(Texture2D texture, Texture2D texture2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001922")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC6D60", Offset = "0xAC6D60", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "CreateTextureAssetsWithPal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Texture2D(Texture2D texture, Texture2D texture2, Texture2D texture3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001923")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC6ED4", Offset = "0xAC6ED4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Texture2D(Texture2D texture, TextureAtlasEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001924")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC6FCC", Offset = "0xAC6FCC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadTexture2D", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Texture2D(TextureAtlasDB textureAtlas, TextureAtlasEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001925")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC70E4", Offset = "0xAC70E4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CreateEmptyTexture(object data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001926")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7158", Offset = "0xAC7158", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureManager), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicDebugDrawer), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_IsMainThread", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution.ExecutionSnippet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExecuteOnMainThread", MemberParameters = new object[]
		{
			typeof(MainThreadExecution.ExecutionSnippet),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Texture2D(GraphicsDevice device, int width, int height)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001927")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC728C", Offset = "0xAC728C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001928")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC72B4", Offset = "0xAC72B4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, int arraySize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001929")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC72D8", Offset = "0xAC72D8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTarget2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(DepthFormat),
			typeof(int),
			typeof(RenderTargetUsage),
			typeof(Texture2D.SurfaceType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, Texture2D.SurfaceType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600192A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC68FC", Offset = "0xAC68FC", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTarget2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(DepthFormat),
			typeof(int),
			typeof(RenderTargetUsage),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTarget2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(DepthFormat),
			typeof(int),
			typeof(RenderTargetUsage),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTarget2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(DepthFormat),
			typeof(int),
			typeof(RenderTargetUsage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTarget2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(DepthFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTarget2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Texture2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Texture2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(TextureAtlasEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextureAtlasDB),
			typeof(TextureAtlasEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "CalculateMipLevels", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, Texture2D.SurfaceType type, bool shared, int arraySize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600192B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7300", Offset = "0xAC7300", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SaveAsPng(Stream stream, int width, int height)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600192C")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0DB4", Offset = "0x15A0DB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetData<T>(T[] data, int start, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600192D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7304", Offset = "0xAC7304", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void ConvertToABGR(int pixelHeight, int pixelWidth, int[] pixels)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002778")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int UnityWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4002779")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int UnityHeight;

		[global::Cpp2ILInjected.Token(Token = "0x400277A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public readonly int Width;

		[global::Cpp2ILInjected.Token(Token = "0x400277B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public readonly int Height;

		[global::Cpp2ILInjected.Token(Token = "0x400277C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		internal int ArraySize;

		[global::Cpp2ILInjected.Token(Token = "0x400277D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal float TexelWidth;

		[global::Cpp2ILInjected.Token(Token = "0x400277E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		internal float TexelHeight;

		[global::Cpp2ILInjected.Token(Token = "0x400277F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float TextureOffsetScale;

		[global::Cpp2ILInjected.Token(Token = "0x4002780")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public bool SharedBatching;

		[global::Cpp2ILInjected.Token(Token = "0x4002781")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D")]
		public bool NonSharedHeadInsert;

		[global::Cpp2ILInjected.Token(Token = "0x4002782")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public TextureAtlasEntry PackedEntry;

		[global::Cpp2ILInjected.Token(Token = "0x4002783")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool loadRequested;

		[global::Cpp2ILInjected.Token(Token = "0x4002784")]
		public static bool ignoreLoad;

		[global::Cpp2ILInjected.Token(Token = "0x4002785")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool _textureLoaded;

		[global::Cpp2ILInjected.Token(Token = "0x4002786")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private RenderTexture _unityRenderTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4002787")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Texture2D _unityTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4002788")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Texture2D _unityAlphaTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4002789")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Texture2D _unityPalTexture;

		[global::Cpp2ILInjected.Token(Token = "0x400278A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public TextureAtlasDB _textureAtlas;

		[global::Cpp2ILInjected.Token(Token = "0x400278B")]
		private static int _nextTextureId;

		[global::Cpp2ILInjected.Token(Token = "0x400278C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private readonly int _batchTextureIndex;

		[global::Cpp2ILInjected.Token(Token = "0x400278D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public int BatchTextureIndex;

		[global::Cpp2ILInjected.Token(Token = "0x400278E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string _sourceLoadAsset;

		[global::Cpp2ILInjected.Token(Token = "0x20003AB")]
		protected internal enum SurfaceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x4002790")]
			Texture,
			[global::Cpp2ILInjected.Token(Token = "0x4002791")]
			RenderTarget,
			[global::Cpp2ILInjected.Token(Token = "0x4002792")]
			SwapChainRenderTarget
		}

		[global::Cpp2ILInjected.Token(Token = "0x20003AC")]
		public delegate Texture2D TextureLoader(int data);
	}
}
