#!/bin/bash

#for i in {13..20}
#do

i="11"
CLASSNAME="Table${i}"
FILEPATH="Models/${CLASSNAME}.cs"
PATTERN=": base(options) { }"

touch $FILEPATH

echo "namespace MigrationAnalysing.Models"       >> $FILEPATH
echo "{"                                         >> $FILEPATH
echo "    public class ${CLASSNAME}"             >> $FILEPATH
echo "    {"                                     >> $FILEPATH
echo "        public int Id { get; set; }"       >> $FILEPATH
echo "    }"                                     >> $FILEPATH
echo "}"                                         >> $FILEPATH

# add table to dbcontext
sed -i "/$PATTERN/a\        public DbSet<${CLASSNAME}> ${CLASSNAME} { get; set; }" "DataAccess/AppDbContext.cs"

# create initial migrations
dotnet ef migrations add "${CLASSNAME}Migration0"

# call script to insert the rest of the columns
./column-inserting-script.sh $CLASSNAME

#done # end for loop

dotnet ef database update
