PROJECT(plasma-sharp)

IF (NOT QT4_FOUND)
	FIND_PACKAGE(Qt4 REQUIRED)
ENDIF (NOT QT4_FOUND)

SET(SRC_CPP src/plasma.cpp src/plasmahandlers.cpp)

SET(SRC_CS src/AssemblyInfo.cs 
 src/PlasmaScripting_DataEngine.cs
 src/PlasmaScripting_Applet.cs
 src/PlasmaScripting_PopupApplet.cs
 src/PlasmaScripting_QGraphicsWidget.cs
 src/Plasma.cs 
plasma/*.cs)

SET(SRC_PLASMASCRIPTENGINEKIMONO
    src/PlasmaScriptengineKimono_Applet.cs
    src/PlasmaScriptengineKimono_DataEngine.cs
    src/PlasmaScriptengineKimono_Compiler.cs)

LINK_DIRECTORIES (${LIBRARY_OUTPUT_PATH})
include_directories (${CMAKE_SOURCE_DIR}/src)
ADD_LIBRARY(plasma-sharp SHARED ${SRC_CPP})
ADD_DEPENDENCIES(plasma-sharp smokeplasma kde-dotnet)
TARGET_LINK_LIBRARIES(plasma-sharp ${SMOKE_PLASMA_LIBRARY}     
    ${SMOKE_BASE_LIBRARY}
    ${QYOTO_LIBRARY}
    ${KDE4_PLASMA_LIBS})

CSHARP_ADD_LIBRARY(plasma-dll "${SRC_CS}" REFERENCES ${QYOTO_ASSEMBLY} kde-dotnet ${QTWEBKIT_ASSEMBLY} COMPILE_FLAGS /warn:0 /keyfile:${QYOTO_KEYFILE})
ADD_DEPENDENCIES(plasma-dll qtwebkit kde-dotnet)

CSHARP_ADD_LIBRARY(PlasmaScriptengineKimono "${SRC_PLASMASCRIPTENGINEKIMONO}" REFERENCES ${QYOTO_ASSEMBLY} kde-dotnet plasma-dll
                   COMPILE_FLAGS /warn:0)
ADD_DEPENDENCIES(PlasmaScriptengineKimono kde-dotnet plasma-dll)

INSTALL(TARGETS plasma-sharp LIBRARY DESTINATION ${LIB_INSTALL_DIR})
INSTALL_ASSEMBLY(plasma-dll DESTINATION ${LIB_INSTALL_DIR} PACKAGE qyoto)

install(FILES ${LIBRARY_OUTPUT_PATH}/PlasmaScriptengineKimono.dll DESTINATION ${DATA_INSTALL_DIR}/plasma_scriptengine_kimono)

install(FILES plasma-scriptengine-kimono-applet.desktop DESTINATION ${SERVICES_INSTALL_DIR})
install(FILES plasma-scriptengine-kimono-dataengine.desktop DESTINATION ${SERVICES_INSTALL_DIR})

add_subdirectory( examples EXCLUDE_FROM_ALL )
