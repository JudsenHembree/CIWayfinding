set PYTHON=python

set SDDIR=../../card/aruco_hallway/
# no ending / on PRJDIR
set PRJDIR=../../card/aruco_hallway/projects
set INDIR=../../data/aruco_hallway/

set VIDDIR=../../data/aruco_hallway/
set PLTDIR=./plots/
set OUTDIR=./data/
set RAWDIR=./data/raw/

%PYTHON% ./card2json.py --indir=%PRJDIR% --outdir="./"

