#!/bin/bash

CLASSNAME=$1
PATTERN="public int Id { get; set; }"

for i in {1..9}; do
  sed -i "/$PATTERN/a\        public string column$i { get; set; } = string.Empty;" "Models/${CLASSNAME}.cs"
  dotnet ef migrations add "${CLASSNAME}Migration${i}"
done
