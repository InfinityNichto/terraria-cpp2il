﻿using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000C6 RID: 198
	[global::Cpp2ILInjected.Token(Token = "0x20000F8")]
	[global::System.Serializable]
	public readonly struct Single : global::System.IComparable, global::System.IConvertible, global::System.IFormattable, global::System.IComparable<float>, global::System.IEquatable<float>, global::System.ISpanFormattable
	{
		// Token: 0x0600088B RID: 2187 RVA: 0x00015E12 File Offset: 0x00014012
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000933")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46BC0", Offset = "0x1C46BC0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static bool IsInfinity(float f)
		{
			throw null;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00015E15 File Offset: 0x00014015
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000934")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46C2C", Offset = "0x1C46C2C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static bool IsNaN(float f)
		{
			throw null;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00015E18 File Offset: 0x00014018
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000935")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46C98", Offset = "0x1C46C98", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool IsNegativeInfinity(float f)
		{
			throw null;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00015E1B File Offset: 0x0001401B
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000936")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46CAC", Offset = "0x1C46CAC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool IsPositiveInfinity(float f)
		{
			throw null;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00015E1E File Offset: 0x0001401E
		[global::Cpp2ILInjected.Token(Token = "0x6000937")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46CC0", Offset = "0x1C46CC0", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_float", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public int CompareTo(object value)
		{
			throw null;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00015E21 File Offset: 0x00014021
		[global::Cpp2ILInjected.Token(Token = "0x6000938")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46E38", Offset = "0x1C46E38", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIBestiary", Member = "SortBackgroundOverlayElements", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.IBestiaryBackgroundOverlayAndColorProvider", "Terraria.GameContent.Bestiary.IBestiaryBackgroundOverlayAndColorProvider" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIInterfaceEdit", Member = "SortGroupByPosition", MemberParameters = new object[] { "GUIPageIconGrouping", "GUIPageIconGrouping" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Projectile.NPCDistanceByIndexComparator", Member = "Compare", MemberParameters = new object[] { "System.Tuple`2<Int32, Single>", "System.Tuple`2<Int32, Single>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DelegateMethods", Member = "CompareDrawSorterByYScale", MemberParameters = new object[] { "Terraria.DataStructures.DrawData", "Terraria.DataStructures.DrawData" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.<>c", Member = "<SetupSortingPriorities>b__5_0", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.SortingSteps.ByCoins", Member = "Compare", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.NPCStatsReportInfoElement", "Terraria.GameContent.Bestiary.NPCStatsReportInfoElement" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.MartianSky.<>c", Member = "<Activate>b__13_0", MemberParameters = new object[] { "Terraria.GameContent.Skies.MartianSky.Ufo", "Terraria.GameContent.Skies.MartianSky.Ufo" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.NebulaSky", Member = "SortMethod", MemberParameters = new object[] { "Terraria.GameContent.Skies.NebulaSky.LightPillar", "Terraria.GameContent.Skies.NebulaSky.LightPillar" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.SolarSky", Member = "SortMethod", MemberParameters = new object[] { "Terraria.GameContent.Skies.SolarSky.Meteor", "Terraria.GameContent.Skies.SolarSky.Meteor" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.StardustSky", Member = "SortMethod", MemberParameters = new object[] { "Terraria.GameContent.Skies.StardustSky.Star", "Terraria.GameContent.Skies.StardustSky.Star" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new object[] { "UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer", Member = "Compare", MemberParameters = new object[] { "UnityEngine.RaycastHit", "UnityEngine.RaycastHit" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int CompareTo(float value)
		{
			throw null;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00015E24 File Offset: 0x00014024
		[global::Cpp2ILInjected.Token(Token = "0x6000939")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46F1C", Offset = "0x1C46F1C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalFloat", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00015E27 File Offset: 0x00014027
		[global::Cpp2ILInjected.Token(Token = "0x600093A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47034", Offset = "0x1C47034", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Rect", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Rect" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Color", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Color", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Color" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Quaternion", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Quaternion", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Quaternion" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Rendering.LODParameters", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Rendering.LODParameters" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AlphaFadeList", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "CrossFadeColor", MemberParameters = new object[]
		{
			"UnityEngine.Color",
			typeof(float),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool Equals(float obj)
		{
			throw null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00015E2A File Offset: 0x0001402A
		[global::Cpp2ILInjected.Token(Token = "0x600093B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47104", Offset = "0x1C47104", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Plane", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Quaternion", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Input.GamePadState", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Input.GamePadTriggers", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Numerics.Vector<>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalFloat", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Bounds", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Rect", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Vector2", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Matrix4x4", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Vector4", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Vector3", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Color", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Quaternion", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Rendering.LODParameters", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Event", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 65)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00015E2D File Offset: 0x0001402D
		[global::Cpp2ILInjected.Token(Token = "0x600093C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4716C", Offset = "0x1C4716C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 63)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00015E30 File Offset: 0x00014030
		[global::Cpp2ILInjected.Token(Token = "0x600093D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C471E8", Offset = "0x1C471E8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalFloat", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00015E33 File Offset: 0x00014033
		[global::Cpp2ILInjected.Token(Token = "0x600093E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47274", Offset = "0x1C47274", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISliderSetting", Member = "GetStringValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawInterface_18_DiagnoseVideo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface", Member = "DrawCameraLock", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.SpriteBatch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.CreativePowers.DifficultySliderPower", Member = "UpdateSliderColorAndShowMultiplierMouseOver", MemberParameters = new object[] { "Terraria.UI.UIElement" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.CreativePowers.ModifyRainPower", Member = "UpdateSliderAndShowMultiplierMouseOver", MemberParameters = new object[] { "Terraria.UI.UIElement" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.CreativePowers.SpawnRateSliderPerPlayerPower", Member = "UpdateSliderAndShowMultiplierMouseOver", MemberParameters = new object[] { "Terraria.UI.UIElement" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "DrawUnityInputDebugger", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00015E36 File Offset: 0x00014036
		[global::Cpp2ILInjected.Token(Token = "0x600093F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C472FC", Offset = "0x1C472FC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "PrettifyPercentDisplay", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.SingleConverter", Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[]
		{
			typeof(float),
			"Newtonsoft.Json.FloatFormatHandling",
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Plane", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Rect", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Vector2", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Matrix4x4", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Vector4", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Vector3", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Color", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Quaternion", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00015E39 File Offset: 0x00014039
		[global::Cpp2ILInjected.Token(Token = "0x6000940")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4738C", Offset = "0x1C4738C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryFormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>), global::System.IFormatProvider provider = null)
		{
			throw null;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00015E3C File Offset: 0x0001403C
		[global::Cpp2ILInjected.Token(Token = "0x6000941")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4744C", Offset = "0x1C4744C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseSingle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00015E3F File Offset: 0x0001403F
		[global::Cpp2ILInjected.Token(Token = "0x6000942")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47510", Offset = "0x1C47510", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.SingleConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToSingle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseSingle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float Parse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00015E42 File Offset: 0x00014042
		[global::Cpp2ILInjected.Token(Token = "0x6000943")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C475E4", Offset = "0x1C475E4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToSingle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref float)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool TryParse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out float result)
		{
			throw null;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00015E45 File Offset: 0x00014045
		[global::Cpp2ILInjected.Token(Token = "0x6000944")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4768C", Offset = "0x1C4768C", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseSingle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "Trim", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool TryParse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.Globalization.NumberFormatInfo info, out float result)
		{
			throw null;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00015E48 File Offset: 0x00014048
		[global::Cpp2ILInjected.Token(Token = "0x6000945")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47B28", Offset = "0x1C47B28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00015E4B File Offset: 0x0001404B
		[global::Cpp2ILInjected.Token(Token = "0x6000946")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47B30", Offset = "0x1C47B30", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00015E4E File Offset: 0x0001404E
		[global::Cpp2ILInjected.Token(Token = "0x6000947")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47B94", Offset = "0x1C47B94", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00015E51 File Offset: 0x00014051
		[global::Cpp2ILInjected.Token(Token = "0x6000948")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47C18", Offset = "0x1C47C18", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00015E54 File Offset: 0x00014054
		[global::Cpp2ILInjected.Token(Token = "0x6000949")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47C7C", Offset = "0x1C47C7C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00015E57 File Offset: 0x00014057
		[global::Cpp2ILInjected.Token(Token = "0x600094A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47CE0", Offset = "0x1C47CE0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00015E5A File Offset: 0x0001405A
		[global::Cpp2ILInjected.Token(Token = "0x600094B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47D44", Offset = "0x1C47D44", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00015E5D File Offset: 0x0001405D
		[global::Cpp2ILInjected.Token(Token = "0x600094C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47DA8", Offset = "0x1C47DA8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00015E60 File Offset: 0x00014060
		[global::Cpp2ILInjected.Token(Token = "0x600094D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47E0C", Offset = "0x1C47E0C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00015E63 File Offset: 0x00014063
		[global::Cpp2ILInjected.Token(Token = "0x600094E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47E70", Offset = "0x1C47E70", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00015E66 File Offset: 0x00014066
		[global::Cpp2ILInjected.Token(Token = "0x600094F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47ED4", Offset = "0x1C47ED4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00015E69 File Offset: 0x00014069
		[global::Cpp2ILInjected.Token(Token = "0x6000950")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47F38", Offset = "0x1C47F38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00015E6C File Offset: 0x0001406C
		[global::Cpp2ILInjected.Token(Token = "0x6000951")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47F40", Offset = "0x1C47F40", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00015E6F File Offset: 0x0001406F
		[global::Cpp2ILInjected.Token(Token = "0x6000952")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C47FA4", Offset = "0x1C47FA4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00015E72 File Offset: 0x00014072
		[global::Cpp2ILInjected.Token(Token = "0x6000953")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C48008", Offset = "0x1C48008", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00015E75 File Offset: 0x00014075
		[global::Cpp2ILInjected.Token(Token = "0x6000954")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4808C", Offset = "0x1C4808C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x04000246 RID: 582
		[global::Cpp2ILInjected.Token(Token = "0x4000398")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly float m_value;

		// Token: 0x04000247 RID: 583
		[global::Cpp2ILInjected.Token(Token = "0x4000399")]
		public const float MinValue = -3.4028235E+38f;

		// Token: 0x04000248 RID: 584
		[global::Cpp2ILInjected.Token(Token = "0x400039A")]
		public const float Epsilon = 1E-45f;

		// Token: 0x04000249 RID: 585
		[global::Cpp2ILInjected.Token(Token = "0x400039B")]
		public const float MaxValue = 3.4028235E+38f;

		// Token: 0x0400024A RID: 586
		[global::Cpp2ILInjected.Token(Token = "0x400039C")]
		public const float PositiveInfinity = float.PositiveInfinity;

		// Token: 0x0400024B RID: 587
		[global::Cpp2ILInjected.Token(Token = "0x400039D")]
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x0400024C RID: 588
		[global::Cpp2ILInjected.Token(Token = "0x400039E")]
		public const float NaN = float.NaN;

		// Token: 0x0400024D RID: 589
		[global::Cpp2ILInjected.Token(Token = "0x400039F")]
		internal const float NegativeZero = 0f;
	}
}