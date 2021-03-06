﻿using Portal.CMS.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portal.CMS.Entities.Seed
{
    public static class PageSeed
    {
        public static void Seed(PortalEntityModel context)
        {
            if (context.Pages.Any())
                return;

            var authenticatedRole = context.Roles.First(x => x.RoleName == "Authenticated");

            context.Pages.Add(new Page
            {
                PageId = 1,
                PageName = "Home",
                PageController = "Home",
                PageAction = "Index",
                DateAdded = DateTime.Now,
                DateUpdated = DateTime.Now,
                PageAssociations = new List<PageAssociation>
                {
                    new PageAssociation { PageSection = new PageSection { PageSectionBody = "<section id=\"section-1\" class=\"header-split background-static height-medium background-picture\" style=\"background-image: url('/Areas/PageBuilder/Content/Images/Sample/sample-2.jpg');background-size: cover;\"> <div id=\"element-2-1491154727776-1\" class=\"details-wrapper\"><div id=\"element-3-1491154727776-1\" class=\"details component-container vertical-alignment\"><div id=\"element-4-1491154727776-1\" class=\"freestyle\"><h1 id=\"element-5-1491154727776-1\" class=\"mce-content-body\" style=\"position: relative; text-align: right;\">PortalCMS 1.3</h1><p id=\"element-6-1491154727776-1\" class=\"mce-content-body\" style=\"position: relative; text-align: right;\">Your website is now ready to use, to start register your first account. The first account registered becomes the owner.</p></div><a id=\"element-8-1491154727776-1\" href=\"/Admin/Authentication/Register\" class=\"launch-modal btn square\" target=\"\">Register Account</a><a id=\"element-1-1491154800156-1\" href=\"http://www.portalcms.online\" class=\"btn square\" target=\"_blank\">Learn More...</a></div></div><div id=\"element-9-1491154727776-1\" class=\"overlay overlay-light ui-droppable\"></div></section>" },},
                    new PageAssociation { PageSection = new PageSection { PageSectionBody = "<section id=\"section-2\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"><div id=\"element-2-1491155804593-2\" class=\"container component-container ui-droppable\"><div id=\"element-3-1491155804593-2\" class=\"freestyle\"><h2 id=\"element-4-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Getting Started</h2><p id=\"element-5-1491155804593-2\" class=\"mce-content-body\" style=\"position: relative;\">We try to make it as simple to get started&nbsp;as possible, but there will always be a bit of a learning curve. Read on to learn about some quick ways to get started.</p></div></div><div id=\"element-6-1491155804593-2\" class=\"container component-container ui-droppable\"><div id=\"element-7-1491155804593-2\" class=\"row component-container ui-droppable\"><div id=\"element-8-1491155804593-2\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"element-9-1491155804593-2\" class=\"image image-icon\" style=\"background-image: url('/Areas/PageBuilder/Content/Images/Sample/icon-9.png');\"></div><div id=\"element-10-1491155804593-2\" class=\"freestyle\"><h4 id=\"element-11-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Add Content</h4><p id=\"element-12-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">The \"Add\" button in the bottom right of your screen allows you to add Sections and Components to your Page</p></div></div><div id=\"element-13-1491155804593-2\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"element-14-1491155804593-2\" class=\"image image-icon\" style=\"background-image: url('/Areas/PageBuilder/Content/Images/Sample/icon-7.png');\"></div><div id=\"element-15-1491155804593-2\" class=\"freestyle\"><h4 id=\"element-17-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Edit Content</h4><p id=\"element-18-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Click on any text or images to change them completely. Or look in the top left of a Section for more controls.</p></div></div><div id=\"element-18-1491155804593-2\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"element-19-1491155804593-2\" class=\"image image-icon\" style=\"background-image: url('/Areas/PageBuilder/Content/Images/Sample/icon-11.png');\"></div><div id=\"element-20-1491155804593-2\" class=\"freestyle\"><h4 id=\"element-23-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Write Blog Posts</h4><p id=\"element-24-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Write a blog Post by clicking \"Add\" in the bottom right of your screen. Or Edit the sample post.</p></div></div><div id=\"element-23-1491155804593-2\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"element-24-1491155804593-2\" class=\"image image-icon\" style=\"background-image: url('/Areas/PageBuilder/Content/Images/Sample/icon-12.png');\"></div><div id=\"element-25-1491155804593-2\" class=\"freestyle\"><h4 id=\"element-11-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Use the Admin Panel</h4><p id=\"element-12-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Click on the Admin Cog in the bottom right of your screen to get into the Admin Panel.</p></div></div><div id=\"element-28-1491155804593-2\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"element-29-1491155804593-2\" class=\"image image-icon\" style=\"background-image: url('/Areas/PageBuilder/Content/Images/Sample/icon-10.png');\"></div><div id=\"element-30-1491155804593-2\" class=\"freestyle\"><h4 id=\"element-11-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Upload Media</h4><p id=\"element-12-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Click on the \"Add\" button in the bottom right of your screen to upload your own Images.</p></div></div><div id=\"element-33-1491155804593-2\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"element-34-1491155804593-2\" class=\"image image-icon\" style=\"background-image: url('/Areas/PageBuilder/Content/Images/Sample/icon-8.png');\"></div><div id=\"element-35-1491155804593-2\" class=\"freestyle\"><h4 id=\"element-11-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Delete Content</h4><p id=\"element-12-1491154890495-6\" class=\"mce-content-body\" style=\"position: relative;\">Click on the Cog in the top left of each Section to delete it and start off with a fresh clean Page.</p></div></div></div></div></section>" },},
                }
            });

            context.Pages.Add(new Page
            {
                PageId = 2,
                PageName = "My Profile",
                PageController = "MyProfile",
                PageAction = "Index",
                DateAdded = DateTime.Now,
                DateUpdated = DateTime.Now,
                PageRoles = new List<PageRole>
                {
                    new PageRole { PageId = 2, RoleId = authenticatedRole.RoleId}
                },
                PageAssociations = new List<PageAssociation>
                {
                    new PageAssociation { PageSection = new PageSection { PageSectionBody = "<section id=\"section-3\" class=\"header background-parallax height-standard background-picture\" style=\"background-image: url('/Areas/PageBuilder/Content/Images/Sample/sample-5.jpg');background-size: cover;\"><div class=\"overlay-medium\" id=\"element-2-1491159138521-3\"></div><div id=\"element-3-1491159138521-3\" class=\"vertical-alignment component-container container\"><div id=\"element-4-1491159138521-3\" class=\"freestyle\"><h1 id=\"element-5-1491159138521-3\" class=\"mce-content-body\" style=\"position: relative;\">My Profile</h1><p id=\"element-6-1491159138521-3\" class=\"mce-content-body\" style=\"position: relative;\">Welcome to your profile, on this page you can update your avatar, account details or provide a personal bio.</p></div></div></section>" },},
                    new PageAssociation { PageSection = new PageSection { PageSectionBody = "<section id=\"section-4\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"><div id=\"element-1-1491159190809-4\" class=\"container component-container container-wide ui-droppable \"><div id=\"element-1-1491159192517-4\" class=\"row component-container ui-droppable \"><div id=\"element-1-1491159194010-4\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable \"><div id=\"element-1-1491159199002-4\" class=\"widget-wrapper \" data-area=\"Profile\" data-controller=\"Widgets\" data-action=\"ProfileWidget\"></div></div><div id=\"element-1-1491159196361-4\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable \"><div id=\"element-1-1491159220197-4\" class=\"widget-wrapper \" data-area=\"Profile\" data-controller=\"Widgets\" data-action=\"BioWidget\"></div></div><div id=\"element-1-1491159195654-4\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable \"><div id=\"element-1-1491159224194-4\" class=\"widget-wrapper \" data-area=\"Profile\" data-controller=\"Widgets\" data-action=\"SecurityWidget\"></div></div></div></div></section>" },},
                }
            });
        }
    }
}