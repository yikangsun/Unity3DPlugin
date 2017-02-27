cmake_minimum_required(VERSION 3.0.0)
project(abc VERSION 0.0.0)

include(CTest)
enable_testing()

add_library(abc SHARED Printer.h Bomb.h Bomb.cpp Arithmetic.cpp Arithmetic.h  api/Api.h api/Api.cpp)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
include(CPack)
