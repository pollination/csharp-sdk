﻿extern alias LBTRestSharp; using System;
using LBT.Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace PollinationSDK
{
	public static class JsonSetting
	{
		private static JsonSerializerSettings _setting;
		public static JsonSerializerSettings AnyOfConvertSetting
		{
			get
			{

				if (_setting == null)
				{
					_setting = new JsonSerializerSettings
					{
						NullValueHandling = NullValueHandling.Ignore,
						//DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
						Converters = new List<JsonConverter>() { new AnyOfJsonConverter() }
					};
				}
				return _setting;
			}
		}

	}
}
