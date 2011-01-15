/***************************************************************************
                          kdehandlers.cpp  -  KDE specific marshallers
                             -------------------
    begin                : Tuesday Jun 16 2008
    copyright            : (C) 2008 by Richard Dale
    email                : richard.j.dale@gmail.org
 ***************************************************************************/

/***************************************************************************
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 ***************************************************************************/

#include <qyoto.h>
#include <smokeqyoto.h>
#include <marshall_macros.h>

#include <kaboutdata.h>
#include <kaction.h>
#include <karchive.h>
#include <kautosavefile.h>
#include <kconfigdialogmanager.h>
#include <kconfigskeleton.h>
#include <kcoreconfigskeleton.h>
#include <kdatatool.h>
#include <kdeversion.h>
#include <kfile.h>
#include <kfileitem.h>
#include <khtml_part.h>
#include <kio/copyjob.h>
#include <kio/jobclasses.h>
#include <klocalizedstring.h>
#include <kmainwindow.h>
#include <kmountpoint.h>
#include <kmultitabbar.h>
#include <knewstuff2/core/entry.h>
#include <kparts/plugin.h>
#include <kplotobject.h>
#include <kplugininfo.h>
#include <kservicegroup.h>
#include <kservice.h>
#include <ksycocatype.h>
#include <ktoolbar.h>
#include <ktrader.h>
#include <kurl.h>
#include <kuser.h>

#include "marshall_macros_kde.h"

void marshall_KServiceList(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
	}
	break;
	case Marshall::ToObject:
	{
		KService::List *offerList = (KService::List*)m->item().s_voidp;
		if (!offerList) {
			m->var().s_voidp = 0;
			break;
		}

		void *av = (*ConstructList)("Kimono.KService");

		for (	KService::List::Iterator it = offerList->begin();
				it != offerList->end();
				++it ) 
		{
			KSharedPtr<KService> *ptr = new KSharedPtr<KService>(*it);
			KService * currentOffer = ptr->data();

			void *obj = (*GetInstance)(currentOffer, true);
			if (obj == 0) {
				smokeqyoto_object * o = alloc_smokeqyoto_object(false, m->smoke(), m->smoke()->idClass("KService").index, currentOffer);
				obj = (*CreateInstance)("Kimono.KService", o);
			}
			(*AddIntPtrToList)(av, obj);
		}

		m->var().s_voidp = av;
	    
		if (m->type().isStack())
			delete offerList;
	}
	break;
	default:
		m->unsupported();
		break;
	}
}

DEF_KSHAREDPTR_MARSHALLER(KSharedConfig, KSharedConfig)
DEF_KSHAREDPTR_MARSHALLER(KMimeType, KMimeType)
DEF_KSHAREDPTR_MARSHALLER(KService, KService)

DEF_LIST_MARSHALLER( KActionList, QList<KAction*>, KAction )
DEF_LIST_MARSHALLER( KActionCollectionList, QList<KActionCollection*>, KActionCollection )
DEF_LIST_MARSHALLER( KAutoSaveFileList, QList<KAutoSaveFile*>, KAutoSaveFile )
DEF_LIST_MARSHALLER( KConfigDialogManagerList, QList<KConfigDialogManager*>, KConfigDialogManager )
DEF_LIST_MARSHALLER( KJobList, QList<KJob*>, KJob )
DEF_LIST_MARSHALLER( KMainWindowList, QList<KMainWindow*>, KMainWindow )
DEF_LIST_MARSHALLER( KMultiTabBarButtonList, QList<KMultiTabBarButton*>, KMultiTabBarButton )
DEF_LIST_MARSHALLER( KMultiTabBarTabList, QList<KMultiTabBarTab*>, KMultiTabBarTab )
DEF_LIST_MARSHALLER( KNSEntryList, QList<KNS::Entry*>, KNS::Entry )
DEF_LIST_MARSHALLER( KPartsPartList, QList<KParts::Part*>, KParts::Part )
DEF_LIST_MARSHALLER( KPartsPluginList, QList<KParts::Plugin*>, KParts::Plugin )
DEF_LIST_MARSHALLER( KPartsReadOnlyPartList, QList<KParts::ReadOnlyPart*>, KParts::ReadOnlyPart )
DEF_LIST_MARSHALLER( KPlotObjectList, QList<KPlotObject*>, KPlotObject )
DEF_LIST_MARSHALLER( KPlotPointList, QList<KPlotPoint*>, KPlotPoint )
DEF_LIST_MARSHALLER( KToolBarList, QList<KToolBar*>, KToolBar )
DEF_LIST_MARSHALLER( KXMLGUIClientList, QList<KXMLGUIClient*>, KXMLGUIClient )


DEF_VALUELIST_MARSHALLER( KAboutLicenseList, QList<KAboutLicense>, KAboutLicense )
DEF_VALUELIST_MARSHALLER( KAboutPersonList, QList<KAboutPerson>, KAboutPerson )
// DEF_VALUELIST_MARSHALLER( KCatalogNameList, QList<KCatalogName>, KCatalogName )
DEF_VALUELIST_MARSHALLER( KCoreConfigSkeletonItemEnumChoiceList, QList<KCoreConfigSkeleton::ItemEnum::Choice>, KCoreConfigSkeleton::ItemEnum::Choice )
DEF_VALUELIST_MARSHALLER( KDataToolInfoList, QList<KDataToolInfo>, KDataToolInfo )
DEF_VALUELIST_MARSHALLER( KFileItemList, QList<KFileItem>, KFileItem )
DEF_VALUELIST_MARSHALLER( KIOCopyInfoList, QList<KIO::CopyInfo>, KIO::CopyInfo )
DEF_VALUELIST_MARSHALLER( KPartsPluginPluginInfoList, QList<KParts::Plugin::PluginInfo>, KParts::Plugin::PluginInfo )
DEF_VALUELIST_MARSHALLER( KPluginInfoList, QList<KPluginInfo>, KPluginInfo )
DEF_VALUELIST_MARSHALLER( KServiceActionList, QList<KServiceAction>, KServiceAction )
DEF_VALUELIST_MARSHALLER( KServiceGroupPtrList, QList<KServiceGroup::Ptr>, KServiceGroup::Ptr )
DEF_VALUELIST_MARSHALLER( KTimeZoneLeapSecondsList, QList<KTimeZone::LeapSeconds>, KTimeZone::LeapSeconds )
DEF_VALUELIST_MARSHALLER( KTimeZonePhaseList, QList<KTimeZone::Phase>, KTimeZone::Phase )
DEF_VALUELIST_MARSHALLER( KTimeZoneTransitionList, QList<KTimeZone::Transition>, KTimeZone::Transition )
DEF_VALUELIST_MARSHALLER( KUrlList, QList<KUrl>, KUrl )
DEF_VALUELIST_MARSHALLER( KUserGroupList, QList<KUserGroup>, KUserGroup )
DEF_VALUELIST_MARSHALLER( KUserList, QList<KUser>, KUser )
DEF_VALUELIST_MARSHALLER( QColorList, QList<QColor>, QColor )

TypeHandler KDE_handlers[] = {
    { "KFileItemList", marshall_KFileItemList },
    { "KFileItemList*", marshall_KFileItemList },
    { "KFileItemList&", marshall_KFileItemList },
    { "KSharedPtr<KMimeType>", marshall_KSharedPtr_KMimeType },
    { "KSharedPtr<KMimeType>&", marshall_KSharedPtr_KMimeType },
    { "KNS::Entry::List", marshall_KNSEntryList },
    { "KPluginInfo::List", marshall_KPluginInfoList },
    { "KPluginInfo::List&", marshall_KPluginInfoList },
    { "KService::List", marshall_KServiceList },
    { "KService::List&", marshall_KServiceList },
    { "KService::Ptr", marshall_KSharedPtr_KService },
    { "KService::Ptr&", marshall_KSharedPtr_KService },
    { "KSharedPtr<KService>", marshall_KSharedPtr_KService },
    { "KSharedPtr<KService>&", marshall_KSharedPtr_KService },
    { "KSharedConfig::Ptr", marshall_KSharedPtr_KSharedConfig },
    { "KSharedConfig::Ptr&", marshall_KSharedPtr_KSharedConfig },
    { "KSharedConfigPtr", marshall_KSharedPtr_KSharedConfig },
    { "KSharedConfigPtr&", marshall_KSharedPtr_KSharedConfig },
    { "KSharedPtr<KSharedConfig>", marshall_KSharedPtr_KSharedConfig },
    { "KSharedPtr<KSharedConfig>&", marshall_KSharedPtr_KSharedConfig },
    { "KUrl::List", marshall_KUrlList },
    { "KUrl::List&", marshall_KUrlList },
    { "KUrlList", marshall_KUrlList },
    { "KUrlList&", marshall_KUrlList },
    { "QList<KAboutLicense>", marshall_KAboutLicenseList },
    { "QList<KAboutPerson>", marshall_KAboutPersonList },
    { "QList<KActionCollection*>&", marshall_KActionCollectionList },
    { "QList<KAction*>", marshall_KActionList },
    { "QList<KAutoSaveFile*>", marshall_KAutoSaveFileList },
//    { "QList<KCatalogName>&", marshall_KCatalogNameList },
    { "QList<KConfigDialogManager*>", marshall_KConfigDialogManagerList },
    { "QList<KCoreConfigSkeleton::ItemEnum::Choice>", marshall_KCoreConfigSkeletonItemEnumChoiceList },
    { "QList<KCoreConfigSkeleton::ItemEnum::Choice>&", marshall_KCoreConfigSkeletonItemEnumChoiceList },
    { "QList<KDataToolInfo>", marshall_KDataToolInfoList },
    { "QList<KDataToolInfo>&", marshall_KDataToolInfoList },
    { "QList<KFileItem>&", marshall_KFileItemList },
    { "QList<KIO::CopyInfo>&", marshall_KIOCopyInfoList },
    { "QList<KJob*>&", marshall_KJobList },
    { "QList<KMainWindow*>", marshall_KMainWindowList },
    { "QList<KMainWindow*>&", marshall_KMainWindowList },
    { "QList<KMultiTabBarButton*>", marshall_KMultiTabBarButtonList },
    { "QList<KMultiTabBarTab*>", marshall_KMultiTabBarTabList },
    { "QList<KParts::Part*>", marshall_KPartsPartList },
    { "QList<KParts::Plugin*>", marshall_KPartsPluginList },
    { "QList<KParts::Plugin::PluginInfo>", marshall_KPartsPluginPluginInfoList },
    { "QList<KParts::Plugin::PluginInfo>&", marshall_KPartsPluginPluginInfoList },
    { "QList<KParts::ReadOnlyPart*>", marshall_KPartsReadOnlyPartList },
    { "QList<KPlotObject*>", marshall_KPlotObjectList },
    { "QList<KPlotObject*>&", marshall_KPlotObjectList },
    { "QList<KPlotPoint*>", marshall_KPlotPointList },
    { "QList<KPluginInfo>", marshall_KPluginInfoList },
    { "QList<KPluginInfo>&", marshall_KPluginInfoList },
    { "QList<KServiceAction>", marshall_KServiceActionList },
    { "QList<KServiceGroup::Ptr>", marshall_KServiceGroupPtrList },
    { "QList<KService::Ptr>", marshall_KServiceList },
    { "QList<KSharedPtr<KService> >", marshall_KServiceList },
    { "QList<KTimeZone::LeapSeconds>", marshall_KTimeZoneLeapSecondsList },
    { "QList<KTimeZone::LeapSeconds>&", marshall_KTimeZoneLeapSecondsList },
    { "QList<KTimeZone::Phase>", marshall_KTimeZonePhaseList },
    { "QList<KTimeZone::Phase>&", marshall_KTimeZonePhaseList },
    { "QList<KTimeZone::Transition>", marshall_KTimeZoneTransitionList },
    { "QList<KTimeZone::Transition>&", marshall_KTimeZoneTransitionList },
    { "QList<KToolBar*>", marshall_KToolBarList },
    { "QList<KUrl>", marshall_KUrlList },
    { "QList<KUserGroup>", marshall_KUserGroupList },
    { "QList<KUser>", marshall_KUserList },
    { "QList<KUser>&", marshall_KUserList },
    { "QList<KXMLGUIClient*>", marshall_KXMLGUIClientList },
    { "QList<KXMLGUIClient*>&", marshall_KXMLGUIClientList },
    { "QList<QColor>", marshall_QColorList },
    { "QList<QColor>&", marshall_QColorList },

    { 0, 0 }
};
