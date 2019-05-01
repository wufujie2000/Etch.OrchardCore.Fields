﻿using Moov2.OrchardCore.Fields.Dictionary.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;

namespace Moov2.OrchardCore.Fields.Dictionary.ViewModels
{
    public class EditDictionaryFieldViewModel
    {
        public DictionaryField Field { get; set; }
        public ContentPart Part { get; set; }
        public ContentPartFieldDefinition PartFieldDefinition { get; set; }

        public string Data { get; set; }
    }
}
