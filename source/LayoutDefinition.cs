using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x020001B0 RID: 432
[global::Cpp2ILInjected.Token(Token = "0x200023F")]
public class LayoutDefinition
{
	// Token: 0x06000C01 RID: 3073 RVA: 0x00023F48 File Offset: 0x00022148
	[global::Cpp2ILInjected.Token(Token = "0x6000D1B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D26A0", Offset = "0x9D26A0", Length = "0x1D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "SerialiseAtPath", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Transform)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "RefreshFields", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(object),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "SaveFields", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "SerialiseAtPath", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Transform)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private static void SerialiseAtPath(BinaryWriter writer, Transform root)
	{
		throw null;
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x00023F4B File Offset: 0x0002214B
	[global::Cpp2ILInjected.Token(Token = "0x6000D1C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D28D8", Offset = "0x9D28D8", Length = "0x26C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Awake", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_bytes", ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "LoadReleaseLayout", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
	{
		typeof(string),
		typeof(BindingFlags)
	}, ReturnType = typeof(MethodInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(MethodInfo),
		typeof(MethodInfo)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object[])
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public static void LoadReleaseLayout()
	{
		throw null;
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00023F4E File Offset: 0x0002214E
	[global::Cpp2ILInjected.Token(Token = "0x6000D1D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2B44", Offset = "0x9D2B44", Length = "0x4BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "LoadReleaseLayout", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "LoadFields", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
	public static bool LoadReleaseLayout(byte[] data)
	{
		throw null;
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00023F51 File Offset: 0x00022151
	[global::Cpp2ILInjected.Token(Token = "0x6000D1E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D28A4", Offset = "0x9D28A4", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "SaveFields", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	public void Save(BinaryWriter writer)
	{
		throw null;
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00023F54 File Offset: 0x00022154
	[global::Cpp2ILInjected.Token(Token = "0x6000D1F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D408C", Offset = "0x9D408C", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "SaveFields", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "LoadFields", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static bool IsList(Type value)
	{
		throw null;
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00023F57 File Offset: 0x00022157
	[global::Cpp2ILInjected.Token(Token = "0x6000D20")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D3034", Offset = "0x9D3034", Length = "0x1058")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "SerialiseAtPath", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Transform)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "SaveFields", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UID), Member = "Generate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "IsList", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "SaveFields", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "get_keys", ReturnType = typeof(Keyframe[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = "get_time", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = "get_value", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = "get_inTangent", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = "get_outTangent", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = "get_inWeight", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = "get_outWeight", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
	private void SaveFields(BinaryWriter writer, Type implementingType, object thisObject)
	{
		throw null;
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00023F5A File Offset: 0x0002215A
	[global::Cpp2ILInjected.Token(Token = "0x6000D21")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D3000", Offset = "0x9D3000", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "LoadFields", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	public void Load(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x00023F5D File Offset: 0x0002215D
	[global::Cpp2ILInjected.Token(Token = "0x6000D22")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D4150", Offset = "0x9D4150", Length = "0xF38")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "LoadReleaseLayout", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "Load", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "LoadFields", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UID), Member = "Generate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(int)
	}, ReturnType = typeof(Array))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
	{
		typeof(object),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "IsList", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "LoadFields", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new object[] { typeof(Keyframe[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(object[])
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
	private void LoadFields(BinaryReader reader, Type implementingType, object thisObject)
	{
		throw null;
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00023F60 File Offset: 0x00022160
	[global::Cpp2ILInjected.Token(Token = "0x6000D23")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2870", Offset = "0x9D2870", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "RefreshFields", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(object),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public bool RefreshStyles(string specificStyle = null)
	{
		throw null;
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00023F63 File Offset: 0x00022163
	[global::Cpp2ILInjected.Token(Token = "0x6000D24")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5088", Offset = "0x9D5088", Length = "0x33C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "SerialiseAtPath", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Transform)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "RefreshStyles", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "RefreshFields", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(object),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransactionButtonStyleDefinitions), Member = "GetDefinition", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TransactionButtonStyle_Definition))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransactionButtonStyle_Definition), Member = "Apply", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "RefreshFields", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(object),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private bool RefreshFields(Type implementingType, object thisObject, string specificStyle = null)
	{
		throw null;
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00023F66 File Offset: 0x00022166
	[global::Cpp2ILInjected.Token(Token = "0x6000D25")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAB98", Offset = "0x9CAB98", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public LayoutDefinition()
	{
		throw null;
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00023F69 File Offset: 0x00022169
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000D26")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D53C4", Offset = "0x9D53C4", Length = "0x114")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	static LayoutDefinition()
	{
		throw null;
	}

	// Token: 0x04001324 RID: 4900
	[global::Cpp2ILInjected.Token(Token = "0x40017D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x04001325 RID: 4901
	[global::Cpp2ILInjected.Token(Token = "0x40017DA")]
	private static List<LayoutDefinition> UIDefinitions;

	// Token: 0x04001326 RID: 4902
	[global::Cpp2ILInjected.Token(Token = "0x40017DB")]
	private static Dictionary<Type, bool> typesEncountered;

	// Token: 0x04001327 RID: 4903
	[global::Cpp2ILInjected.Token(Token = "0x40017DC")]
	private static StringBuilder output;
}
