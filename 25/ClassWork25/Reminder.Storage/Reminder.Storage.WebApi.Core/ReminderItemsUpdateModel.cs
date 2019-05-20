﻿using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reminder.Storage.WebApi.Core
{
	public class ReminderItemsUpdateModel
	{
		[Required]
		public List<Guid> Ids { get; set; }

		[Required]
		public JsonPatchDocument<ReminderItemUpdateModel> PatchDocument { get; set; }
	}
}
