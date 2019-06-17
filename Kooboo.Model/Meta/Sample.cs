﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Kooboo.Model.Meta.Form;
using Kooboo.Model.Meta.Table;

namespace Kooboo.Model.Meta
{
    class Sample : ITableMetaConfigure<Entity>, IFormMetaConfigure<Entity>
    {
        void IMetaConfigure<Entity, TableMeta>.Configure(TableMeta meta)
        {
            meta.Builder<ListViewModel>()
                .Column<LinkCell>(o => o.Name, new Localizable("Name"), o =>
                {
                    o.Action = ActionMeta.EmbeddedPopup(CreateCopyPopupMeta());
                });
        }

        private Popup.PopupMeta CreateCopyPopupMeta()
        {
            throw new NotImplementedException();
        }

        void IMetaConfigure<Entity, FormMeta>.Configure(FormMeta meta)
        {
            meta.Builder<DetailsViewModel>()
                .MergeModel();
        }

    }

    class Entity : Kooboo.Data.Interface.ISiteObject
    {
        public string Name { get; set; }
        public byte ConstType { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
        public Guid Id { get; set; }
    }

    class ListViewModel
    {
        [LinkColumn(ActionType.Redirect, "/_admin/test/list")]
        public string Name { get; set; }
    }

    class DetailsViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
    }

    class EntityApi
    {
        void Delete()
        {
        }
    }
}
