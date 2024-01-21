using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class LayoutDefinition
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400132D")]
	public string name;

	[Cpp2IlInjected.Token(Token = "0x400132E")]
	private static List<LayoutDefinition> UIDefinitions;

	[Cpp2IlInjected.Token(Token = "0x400132F")]
	private static Dictionary<Type, bool> typesEncountered;

	[Cpp2IlInjected.Token(Token = "0x4001330")]
	private static StringBuilder output;

	[Cpp2IlInjected.Token(Token = "0x6000C14")]
	[Cpp2IlInjected.Address(RVA = "0x12D85D8", Offset = "0x12D85D8", VA = "0x12D85D8")]
	private static void SerialiseAtPath(BinaryWriter writer, Transform root)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C15")]
	[Cpp2IlInjected.Address(RVA = "0x12D8844", Offset = "0x12D8844", VA = "0x12D8844")]
	public static void LoadReleaseLayout()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C16")]
	[Cpp2IlInjected.Address(RVA = "0x12D8A70", Offset = "0x12D8A70", VA = "0x12D8A70")]
	public static bool LoadReleaseLayout(byte[] data)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C17")]
	[Cpp2IlInjected.Address(RVA = "0x12D880C", Offset = "0x12D880C", VA = "0x12D880C")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C18")]
	[Cpp2IlInjected.Address(RVA = "0x12DA01C", Offset = "0x12DA01C", VA = "0x12DA01C")]
	public static bool IsList(Type value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C19")]
	[Cpp2IlInjected.Address(RVA = "0x12D8E84", Offset = "0x12D8E84", VA = "0x12D8E84")]
	private void SaveFields(BinaryWriter writer, Type implementingType, object thisObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1A")]
	[Cpp2IlInjected.Address(RVA = "0x12D8E4C", Offset = "0x12D8E4C", VA = "0x12D8E4C")]
	public void Load(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1B")]
	[Cpp2IlInjected.Address(RVA = "0x12DA0F4", Offset = "0x12DA0F4", VA = "0x12DA0F4")]
	private void LoadFields(BinaryReader reader, Type implementingType, object thisObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1C")]
	[Cpp2IlInjected.Address(RVA = "0x12D87D4", Offset = "0x12D87D4", VA = "0x12D87D4")]
	public bool RefreshStyles([Optional] string specificStyle)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1D")]
	[Cpp2IlInjected.Address(RVA = "0x12DB158", Offset = "0x12DB158", VA = "0x12DB158")]
	private bool RefreshFields(Type implementingType, object thisObject, [Optional] string specificStyle)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x12D5970", Offset = "0x12D5970", VA = "0x12D5970")]
	public LayoutDefinition()
	{
	}
}
