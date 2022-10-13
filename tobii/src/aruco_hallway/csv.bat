set PYTHON=python

set SDDIR=../../card/aruco_hallway/
# no ending / on PRJDIR
set PRJDIR=../../card/aruco_hallway/projects
set INDIR=../../data/aruco_hallway/

%PYTHON% ../tobii/tobii_grab_data.py aruco_hallway.json --convert 0 --file=%SDDIR%
