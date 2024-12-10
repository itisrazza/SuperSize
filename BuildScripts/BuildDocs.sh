#!/bin/bash

set -e

# generate the docs
cd SuperSize.Plugin.Docs
doxygen

# copy them into the website
cp -rv dist/html ../Website/dist/plugin-docs
