let isEven n = n%2 = 0
let square n = n*n

let rec FastExp b n =
  if n=0 then 1
  elif isEven n then square (FastExp b n/2)
  else b * FastExp b n-1

#time
FastExp 2 1000