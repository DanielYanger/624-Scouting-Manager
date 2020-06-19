import os
import shutil

try:
  import pandas as pd
except ImportError:
  print ("Trying to Install required modules: pandas")
  os.system('python -m pip install pandas')

import csv
import pandas as pd
import json 
import sys
from os import listdir
from os.path import isfile, join


username = os.getlogin()
print(sys.argv[1])
file = open(sys.argv[1])
json_data = json.load(file)

print(sys.argv[2])

if sys.argv[2]=='True':
    try:
      full_data = pd.read_csv(filepath_or_buffer=fr'C:\Users\{username}\Desktop\Match Data.csv')
      
      #full_data = pd.read_csv(filepath_or_buffer=fr'C:\New Folder\Match Data.csv')
      for i in json_data:
        full_data = full_data.append(i,ignore_index=True)
    
  
    except FileNotFoundError:
      for i in json_data:
          try:
            full_data = full_data.append(i,ignore_index=True)
          except:
            full_data = pd.DataFrame()
            full_data = full_data.append(i,ignore_index=True)

    duplicated = full_data.duplicated(keep='last', subset=["Team Number","Match Number"])
    index=0
    for i in duplicated:
      if i:
        full_data=full_data.drop(full_data.index[index])
        index-=1
      index+=1

    full_data.to_csv(fr'C:\Users\{username}\Desktop\Match Data.csv', index=False)
    #full_data.to_csv(fr'C:\New Folder\Match Data.csv', index=False)


else:
    try:
      full_data = pd.read_csv(filepath_or_buffer=fr'C:\Users\{username}\Desktop\Pit Data.csv')
      for i in json_data:
        full_data = full_data.append(i,ignore_index=True)
    
  
    except FileNotFoundError:
      for i in json_data:
          try:
            full_data = full_data.append(i,ignore_index=True)
          except:
            full_data = pd.DataFrame()
            full_data = full_data.append(i,ignore_index=True)

    duplicated = full_data.duplicated(keep='last', subset=["Team Number"])
    index=0
    for i in duplicated:
      if i:
        full_data=full_data.drop(full_data.index[index])
        index-=1
      index+=1

    full_data.to_csv(fr'C:\Users\{username}\Desktop\Pit Data.csv', index=False)


print("yeet")
