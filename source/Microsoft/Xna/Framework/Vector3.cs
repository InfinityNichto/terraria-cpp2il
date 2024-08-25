using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Terraria;
using Terraria.Cinematics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.Events;
using Terraria.GameContent.Shaders;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.Graphics.Shaders;
using Terraria.Utilities;
using UnityEngine;

namespace Microsoft.Xna.Framework
{
	[global::Cpp2ILInjected.Token(Token = "0x2000331")]
	[Serializable]
	public struct Vector3 : IEquatable<Vector3>
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001ED")]
		public static Vector3 Zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013CD")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91300", Offset = "0xA91300", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001EE")]
		public static Vector3 One
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013CE")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9135C", Offset = "0xA9135C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001EF")]
		public static Vector3 UnitX
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013CF")]
			[global::Cpp2ILInjected.Address(RVA = "0xA913B8", Offset = "0xA913B8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F0")]
		public static Vector3 UnitY
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D0")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91414", Offset = "0xA91414", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F1")]
		public static Vector3 UnitZ
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D1")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91470", Offset = "0xA91470", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F2")]
		public static Vector3 Up
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D2")]
			[global::Cpp2ILInjected.Address(RVA = "0xA914CC", Offset = "0xA914CC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F3")]
		public static Vector3 Down
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D3")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91528", Offset = "0xA91528", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F4")]
		public static Vector3 Right
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D4")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91584", Offset = "0xA91584", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F5")]
		public static Vector3 Left
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D5")]
			[global::Cpp2ILInjected.Address(RVA = "0xA915E0", Offset = "0xA915E0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F6")]
		public static Vector3 Forward
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D6")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9163C", Offset = "0xA9163C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001F7")]
		public static Vector3 Backward
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013D7")]
			[global::Cpp2ILInjected.Address(RVA = "0xA91698", Offset = "0xA91698", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013D8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CC00", Offset = "0xA8CC00", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "get_Backward", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "get_Down", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "get_Forward", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "get_Left", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "get_Right", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "get_Translation", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "get_Up", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgr565), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem_VisualEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "rgbToHsl", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Mushroom", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_117_BloodNautilus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_003_Fighters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyEquipFunctional", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitHeldItemLight", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "ProjLight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_166_Dove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_165_Whip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_157_SharpTears", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_007_GrapplingHooks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_026", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_043", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_075", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_130_FlameBurstTower", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_136_BetsyBreath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_137_LightningAura", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_139_ExplosiveTrapExplosion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_144_DD2Pet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "EmitGolfCartlight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "XZW", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "YZW", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ColorSlidersSet), Member = "GetHSLVector", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "UseSecondaryColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(HairShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "UseSecondaryColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(HairShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "UseSecondaryColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "UseSecondaryColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "UpdateLightDecay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "set_LightDecayThroughAir", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "set_LightDecayThroughSolid", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "DryadPortalFade", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 119)]
		public Vector3(float x, float y, float z)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013D9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA916F4", Offset = "0xA916F4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		public Vector3(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013DA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91700", Offset = "0xA91700", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Vector3(Vector2 value, float z)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013DB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9170C", Offset = "0xA9170C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Add(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013DC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9171C", Offset = "0xA9171C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013DD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91740", Offset = "0xA91740", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Barycentric", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013DE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA917EC", Offset = "0xA917EC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Barycentric", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Barycentric(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, float amount1, float amount2, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA918A0", Offset = "0xA918A0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91948", Offset = "0xA91948", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void CatmullRom(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, ref Vector3 value4, float amount, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA919FC", Offset = "0xA919FC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91A88", Offset = "0xA91A88", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Clamp(ref Vector3 value1, ref Vector3 min, ref Vector3 max, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CD38", Offset = "0xA8CD38", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector3 Cross(Vector3 vector1, Vector3 vector2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91B10", Offset = "0xA91B10", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateWorld", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateBillboard", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(Vector3?),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static void Cross(ref Vector3 vector1, ref Vector3 vector2, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91B5C", Offset = "0xA91B5C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Distance(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91BFC", Offset = "0xA91BFC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Distance(ref Vector3 value1, ref Vector3 value2, out float result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91CAC", Offset = "0xA91CAC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float DistanceSquared(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91CD0", Offset = "0xA91CD0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void DistanceSquared(ref Vector3 value1, ref Vector3 value2, out float result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013E9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D08", Offset = "0xA91D08", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Divide(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013EA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D18", Offset = "0xA91D18", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Divide(Vector3 value1, float value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013EB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D30", Offset = "0xA91D30", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector3 value1, float divisor, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013EC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D54", Offset = "0xA91D54", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013ED")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CDF4", Offset = "0xA8CDF4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateShadow", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Plane),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static float Dot(Vector3 vector1, Vector3 vector2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013EE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91D78", Offset = "0xA91D78", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013EF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91DA4", Offset = "0xA91DA4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91E78", Offset = "0xA91E78", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(Vector3 other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D43C", Offset = "0xA8D43C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91F18", Offset = "0xA91F18", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA91FC0", Offset = "0xA91FC0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2, float amount, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92060", Offset = "0xA92060", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_NightsEdge", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_Excalibur", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TheHorsemansBlade", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TrueExcalibur", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TrueNightsEdge", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TerraBlade2", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_TerraBlade2Shot", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_067_FreakingPirates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "IsPlayerSafe", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float Length()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA920E0", Offset = "0xA920E0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float LengthSquared()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92100", Offset = "0xA92100", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetSubLight", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_182_FinalFractal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_075", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "DryadPortalFade", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92184", Offset = "0xA92184", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Lerp(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92210", Offset = "0xA92210", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Max(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013F9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92284", Offset = "0xA92284", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Max(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013FA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA922F4", Offset = "0xA922F4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColorClamped", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 Min(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92368", Offset = "0xA92368", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void Min(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA923D8", Offset = "0xA923D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Multiply(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA923E8", Offset = "0xA923E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Multiply(Vector3 value1, float scaleFactor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013FE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA923F8", Offset = "0xA923F8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector3 value1, float scaleFactor, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60013FF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92414", Offset = "0xA92414", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001400")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92438", Offset = "0xA92438", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Negate(Vector3 value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001401")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92448", Offset = "0xA92448", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Vector3 value, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001402")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92464", Offset = "0xA92464", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateWorld", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Normalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001403")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CD60", Offset = "0xA8CD60", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "Normalize", MemberParameters = new object[]
		{
			typeof(ref Plane),
			typeof(ref Plane)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector3 Normalize(Vector3 value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001404")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92518", Offset = "0xA92518", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateWorld", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateBillboard", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(Vector3?),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Normalize(ref Vector3 value, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001405")]
		[global::Cpp2ILInjected.Address(RVA = "0xA925D8", Offset = "0xA925D8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector3 Reflect(Vector3 vector, Vector3 normal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001406")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92684", Offset = "0xA92684", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Reflect(ref Vector3 vector, ref Vector3 normal, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001407")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92760", Offset = "0xA92760", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001408")]
		[global::Cpp2ILInjected.Address(RVA = "0xA927E4", Offset = "0xA927E4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static void SmoothStep(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001409")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92870", Offset = "0xA92870", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 Subtract(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600140A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92880", Offset = "0xA92880", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600140B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA928A4", Offset = "0xA928A4", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgr565), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600140C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA929D8", Offset = "0xA929D8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Viewport), Member = "Project", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix),
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Viewport), Member = "Unproject", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix),
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect_HallowBoss", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(ref Vector2),
			typeof(int),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref Vector2),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Matrix),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector3 Transform(Vector3 position, Matrix matrix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600140D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92A50", Offset = "0xA92A50", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector3), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600140E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92AB4", Offset = "0xA92AB4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "SetPosition", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public Vector3 UnityVec3()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600140F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92AC0", Offset = "0xA92AC0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector3 Transform(Vector3 value, Quaternion rotation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001410")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92AF8", Offset = "0xA92AF8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001411")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92B30", Offset = "0xA92B30", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector3[] sourceArray, ref Quaternion rotation, Vector3[] destinationArray)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001412")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92B68", Offset = "0xA92B68", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001413")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92BA0", Offset = "0xA92BA0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001414")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92BD8", Offset = "0xA92BD8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001415")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92C10", Offset = "0xA92C10", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TransformNormal(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001416")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92C48", Offset = "0xA92C48", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TransformNormal(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001417")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92C80", Offset = "0xA92C80", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector3 TransformNormal(Vector3 normal, Matrix matrix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001418")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92D3C", Offset = "0xA92D3C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void TransformNormal(ref Vector3 normal, ref Matrix matrix, out Vector3 result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001419")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D3D4", Offset = "0xA8D3D4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600141A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92D90", Offset = "0xA92D90", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "FindCollisionTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(List<Point>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static bool operator !=(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600141B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DB8", Offset = "0xA92DB8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_065_Butterflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "GetLight", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static Vector3 operator +(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600141C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DC8", Offset = "0xA92DC8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 operator -(Vector3 value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600141D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CD28", Offset = "0xA8CD28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateBillboard", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(Vector3?),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateLookAt", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Vector3),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		public static Vector3 operator -(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600141E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DD8", Offset = "0xA92DD8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "GetAlpha", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColorClamped", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public static Vector3 operator *(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600141F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DE8", Offset = "0xA92DE8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem_VisualEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor9Slice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Vector3[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor4Slice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Vector3[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Mushroom", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_065_Butterflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_120_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_117_BloodNautilus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_112_FairyCritter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_003_Fighters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Yoraiz0rEye", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitHeldItemLight", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_182_FinalFractal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_180_FairyQueenSunDance", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_167_SparkleGuitar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_166_Dove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_067_FreakingPirates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_157_SharpTears", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_147_Celeb2Rocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_026", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_043", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_075", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_130_FlameBurstTower", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods), Member = "CastLightOpen_StopForSolids_ScaleWithDistance", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "actColor", MemberParameters = new object[] { typeof(ref Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile_PC), Member = "actColor", MemberParameters = new object[] { typeof(ref Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "UpdateLightDecay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ExportTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyTileLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref FastRandom),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 93)]
		public static Vector3 operator *(Vector3 value, float scaleFactor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001420")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92DF8", Offset = "0xA92DF8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector3 operator *(float scaleFactor, Vector3 value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001421")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92E0C", Offset = "0xA92E0C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static Vector3 operator /(Vector3 value1, Vector3 value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001422")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92E1C", Offset = "0xA92E1C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "GetLight", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector3 operator /(Vector3 value, float divider)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001423")]
		[global::Cpp2ILInjected.Address(RVA = "0xA92E34", Offset = "0xA92E34", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Vector3()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002278")]
		private static Vector3 zero;

		[global::Cpp2ILInjected.Token(Token = "0x4002279")]
		private static Vector3 one;

		[global::Cpp2ILInjected.Token(Token = "0x400227A")]
		private static Vector3 unitX;

		[global::Cpp2ILInjected.Token(Token = "0x400227B")]
		private static Vector3 unitY;

		[global::Cpp2ILInjected.Token(Token = "0x400227C")]
		private static Vector3 unitZ;

		[global::Cpp2ILInjected.Token(Token = "0x400227D")]
		private static Vector3 up;

		[global::Cpp2ILInjected.Token(Token = "0x400227E")]
		private static Vector3 down;

		[global::Cpp2ILInjected.Token(Token = "0x400227F")]
		private static Vector3 right;

		[global::Cpp2ILInjected.Token(Token = "0x4002280")]
		private static Vector3 left;

		[global::Cpp2ILInjected.Token(Token = "0x4002281")]
		private static Vector3 forward;

		[global::Cpp2ILInjected.Token(Token = "0x4002282")]
		private static Vector3 backward;

		[global::Cpp2ILInjected.Token(Token = "0x4002283")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float X;

		[global::Cpp2ILInjected.Token(Token = "0x4002284")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float Y;

		[global::Cpp2ILInjected.Token(Token = "0x4002285")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float Z;
	}
}
