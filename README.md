# IntegerAdditionBenchmark
Integer Addition Benchmark in C# - various implementations!


## Run on E3-1245v3 4c/8t


## Run on E5-2650 v3 2x 10c/20t

```
BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.165 (1803/April2018Update/Redstone4)
Intel Xeon CPU E5-2650 v3 2.30GHz, 1 CPU, 20 logical and 10 physical cores
Frequency=2240900 Hz, Resolution=446.2493 ns, Timer=TSC
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  
                               Method |      Size |                 Mean |              Error |             StdDev |                 Median |
  ------------------------------------- |---------- |---------------------:|-------------------:|-------------------:|---------------------:|
                              ForLoop |        15 |             24.16 ns |          0.2587 ns |          0.2160 ns |             24.10 ns |
                         ForLoopConst |        15 |             23.39 ns |          0.6701 ns |          1.1197 ns |             22.81 ns |
                       ForLoopReverse |        15 |             30.06 ns |          0.3787 ns |          0.3543 ns |             30.08 ns |
          ForLoopReversePostIncrement |        15 |             30.96 ns |          0.2321 ns |          0.2171 ns |             30.94 ns |
                          ParallelFor |        15 |          4,170.99 ns |         10.9163 ns |          9.6770 ns |          4,169.49 ns |
               ParallelForPartitioned |        15 |         13,119.71 ns |         67.8869 ns |         60.1800 ns |         13,125.77 ns |
                              LinqZip |        15 |            747.44 ns |         16.4801 ns |         38.5217 ns |            725.57 ns |
              LinqSelectWithElementAt |        15 |          1,208.21 ns |          6.8540 ns |          6.4112 ns |          1,209.73 ns |
      ParallelLinqSelectWithElementAt |        15 |         63,729.47 ns |      1,269.9024 ns |      2,121.7216 ns |         63,713.88 ns |
         LinqSelectWithDirectAccessor |        15 |            565.93 ns |          3.7052 ns |          3.2846 ns |            565.86 ns |
 ParallelLinqSelectWithDirectAccessor |        15 |         63,070.51 ns |      1,258.2623 ns |      1,883.3078 ns |         63,417.44 ns |
                              SimdFor |        15 |             20.22 ns |          0.2811 ns |          0.2492 ns |             20.15 ns |
                      ParallelSimdFor |        15 |          6,448.39 ns |         16.8080 ns |         15.7222 ns |          6,447.04 ns |
                              ForLoop |       255 |            244.68 ns |          2.4733 ns |          2.3135 ns |            244.75 ns |
                         ForLoopConst |       255 |            242.38 ns |          4.1520 ns |          3.2416 ns |            241.76 ns |
                       ForLoopReverse |       255 |            316.65 ns |          1.0138 ns |          0.8987 ns |            316.57 ns |
          ForLoopReversePostIncrement |       255 |            331.08 ns |         12.3166 ns |         18.0535 ns |            324.31 ns |
                          ParallelFor |       255 |         19,803.63 ns |        143.3602 ns |        134.0992 ns |         19,843.94 ns |
               ParallelForPartitioned |       255 |         15,519.76 ns |         73.4009 ns |         68.6592 ns |         15,538.96 ns |
                              LinqZip |       255 |          7,427.08 ns |         64.2296 ns |         50.1463 ns |          7,411.35 ns |
              LinqSelectWithElementAt |       255 |         15,438.35 ns |        100.7598 ns |         94.2508 ns |         15,442.68 ns |
      ParallelLinqSelectWithElementAt |       255 |         65,017.53 ns |      1,280.8282 ns |      1,994.0953 ns |         65,278.61 ns |
         LinqSelectWithDirectAccessor |       255 |          5,356.16 ns |         26.8645 ns |         25.1291 ns |          5,360.97 ns |
 ParallelLinqSelectWithDirectAccessor |       255 |         62,947.14 ns |      1,257.7184 ns |      1,882.4936 ns |         63,261.34 ns |
                              SimdFor |       255 |            128.30 ns |          0.8919 ns |          0.8343 ns |            128.29 ns |
                      ParallelSimdFor |       255 |          7,135.54 ns |         25.1573 ns |         22.3013 ns |          7,133.17 ns |
                              ForLoop |      4095 |          3,620.97 ns |         69.1046 ns |         64.6405 ns |          3,599.96 ns |
                         ForLoopConst |      4095 |          3,386.17 ns |          9.3296 ns |          8.2705 ns |          3,386.41 ns |
                       ForLoopReverse |      4095 |          4,591.17 ns |         27.6000 ns |         23.0472 ns |          4,595.03 ns |
          ForLoopReversePostIncrement |      4095 |          4,583.17 ns |         18.5129 ns |         16.4112 ns |          4,578.42 ns |
                          ParallelFor |      4095 |        105,566.44 ns |      1,100.7803 ns |      1,029.6705 ns |        105,602.68 ns |
               ParallelForPartitioned |      4095 |         23,554.18 ns |        119.1013 ns |        111.4075 ns |         23,572.03 ns |
                              LinqZip |      4095 |        113,608.56 ns |        676.7689 ns |        633.0500 ns |        113,481.69 ns |
              LinqSelectWithElementAt |      4095 |        236,533.45 ns |        379.9270 ns |        336.7954 ns |        236,522.63 ns |
      ParallelLinqSelectWithElementAt |      4095 |         91,384.40 ns |        241.6222 ns |        226.0135 ns |         91,411.43 ns |
         LinqSelectWithDirectAccessor |      4095 |         81,207.42 ns |        647.2789 ns |        605.4650 ns |         81,174.34 ns |
 ParallelLinqSelectWithDirectAccessor |      4095 |         72,716.81 ns |      1,393.8579 ns |      1,368.9547 ns |         72,219.37 ns |
                              SimdFor |      4095 |          2,242.92 ns |          9.9474 ns |          9.3048 ns |          2,241.46 ns |
                      ParallelSimdFor |      4095 |         11,325.69 ns |         14.0796 ns |         13.1700 ns |         11,325.46 ns |
                              ForLoop |     65535 |        141,960.92 ns |      1,527.7998 ns |      1,429.1048 ns |        142,050.65 ns |
                         ForLoopConst |     65535 |        142,641.71 ns |      1,069.4773 ns |        948.0637 ns |        142,688.45 ns |
                       ForLoopReverse |     65535 |        157,064.33 ns |      2,086.2218 ns |      1,849.3811 ns |        156,670.72 ns |
          ForLoopReversePostIncrement |     65535 |        155,764.61 ns |      1,712.5990 ns |      1,601.9660 ns |        156,064.64 ns |
                          ParallelFor |     65535 |        383,291.49 ns |      3,498.9031 ns |      3,272.8758 ns |        383,233.86 ns |
               ParallelForPartitioned |     65535 |        124,726.78 ns |      1,687.0750 ns |      1,495.5479 ns |        124,851.68 ns |
                              LinqZip |     65535 |      1,943,324.03 ns |      4,428.6300 ns |      4,142.5428 ns |      1,944,076.90 ns |
              LinqSelectWithElementAt |     65535 |      4,052,044.04 ns |     17,413.1580 ns |     16,288.2772 ns |      4,056,087.01 ns |
      ParallelLinqSelectWithElementAt |     65535 |        392,665.57 ns |      1,875.0303 ns |      1,753.9043 ns |        392,543.57 ns |
         LinqSelectWithDirectAccessor |     65535 |      1,437,268.36 ns |      7,410.0368 ns |      6,931.3524 ns |      1,435,984.93 ns |
 ParallelLinqSelectWithDirectAccessor |     65535 |        237,086.89 ns |        829.2310 ns |        775.6631 ns |        236,926.12 ns |
                              SimdFor |     65535 |        140,404.19 ns |      1,493.4340 ns |      1,396.9589 ns |        140,119.73 ns |
                      ParallelSimdFor |     65535 |        114,192.21 ns |      2,282.1799 ns |      2,134.7523 ns |        114,156.37 ns |
                              ForLoop |   1048575 |      2,583,267.62 ns |     93,624.2524 ns |    273,106.3386 ns |      2,629,690.59 ns |
                         ForLoopConst |   1048575 |      2,492,548.52 ns |     73,603.3777 ns |    201,488.0586 ns |      2,563,486.11 ns |
                       ForLoopReverse |   1048575 |      2,707,588.00 ns |     76,713.0161 ns |    208,703.4179 ns |      2,772,781.20 ns |
          ForLoopReversePostIncrement |   1048575 |      2,797,422.20 ns |     80,352.8350 ns |    215,862.6732 ns |      2,877,502.66 ns |
                          ParallelFor |   1048575 |      2,667,360.91 ns |     40,612.8621 ns |     37,989.2927 ns |      2,666,708.97 ns |
               ParallelForPartitioned |   1048575 |      1,856,410.58 ns |     16,486.1691 ns |     15,421.1713 ns |      1,855,882.58 ns |
                              LinqZip |   1048575 |     30,689,392.38 ns |    202,461.9518 ns |    158,068.9609 ns |     30,705,673.50 ns |
              LinqSelectWithElementAt |   1048575 |     64,938,567.78 ns |    227,864.8121 ns |    190,277.4199 ns |     64,902,996.56 ns |
      ParallelLinqSelectWithElementAt |   1048575 |      4,497,234.65 ns |     81,172.9285 ns |     75,929.2003 ns |      4,490,627.37 ns |
         LinqSelectWithDirectAccessor |   1048575 |     22,514,156.56 ns |    449,857.5193 ns |    799,621.2833 ns |     21,965,113.77 ns |
 ParallelLinqSelectWithDirectAccessor |   1048575 |      2,318,621.06 ns |     31,880.2992 ns |     28,261.0521 ns |      2,321,020.40 ns |
                              SimdFor |   1048575 |      2,461,635.94 ns |     80,450.4534 ns |    220,231.8178 ns |      2,536,501.97 ns |
                      ParallelSimdFor |   1048575 |      1,559,489.91 ns |      8,992.1470 ns |      8,411.2590 ns |      1,557,714.91 ns |
                              ForLoop |  16777215 |     48,357,846.13 ns |    941,479.3442 ns |    834,596.8341 ns |     48,302,447.47 ns |
                         ForLoopConst |  16777215 |     47,404,414.27 ns |    797,146.9048 ns |    706,649.8986 ns |     47,265,465.58 ns |
                       ForLoopReverse |  16777215 |     52,462,386.34 ns |    737,069.4360 ns |    615,486.3020 ns |     52,407,559.46 ns |
          ForLoopReversePostIncrement |  16777215 |     57,079,062.98 ns |  1,199,803.0805 ns |  3,537,646.4532 ns |     57,450,726.64 ns |
                          ParallelFor |  16777215 |     32,457,572.45 ns |    640,995.5174 ns |  1,172,096.5487 ns |     32,464,676.58 ns |
               ParallelForPartitioned |  16777215 |     29,274,102.11 ns |    200,450.7046 ns |    187,501.6952 ns |     29,299,095.79 ns |
                              LinqZip |  16777215 |    492,851,118.49 ns |  1,053,163.0283 ns |    933,601.5013 ns |    492,899,504.66 ns |
              LinqSelectWithElementAt |  16777215 |  1,069,073,440.99 ns | 21,307,741.6520 ns | 41,052,784.2968 ns |  1,080,566,290.33 ns |
      ParallelLinqSelectWithElementAt |  16777215 |     62,209,026.47 ns |  1,339,629.1389 ns |  1,253,089.8058 ns |     61,924,623.54 ns |
         LinqSelectWithDirectAccessor |  16777215 |    364,866,757.41 ns |  1,983,662.0510 ns |  1,548,712.7154 ns |    364,850,283.37 ns |
 ParallelLinqSelectWithDirectAccessor |  16777215 |     34,615,326.75 ns |    526,691.7838 ns |    466,898.5018 ns |     34,487,348.83 ns |
                              SimdFor |  16777215 |     47,340,989.89 ns |    577,967.6237 ns |    540,631.2212 ns |     47,273,700.91 ns |
                      ParallelSimdFor |  16777215 |     25,004,364.88 ns |    213,239.8400 ns |    189,031.5453 ns |     25,018,107.96 ns |
                              ForLoop | 268435455 |    577,825,219.03 ns |  1,316,377.0607 ns |  1,231,339.7995 ns |    577,728,144.94 ns |
                         ForLoopConst | 268435455 |    578,807,999.53 ns |  1,352,584.2050 ns |  1,129,468.9615 ns |    579,112,856.44 ns |
                       ForLoopReverse | 268435455 |    643,531,735.76 ns |  3,636,423.6129 ns |  3,401,512.5727 ns |    642,804,676.69 ns |
          ForLoopReversePostIncrement | 268435455 |    654,555,848.10 ns |  3,132,009.4658 ns |  2,929,683.3124 ns |    655,260,832.70 ns |
                          ParallelFor | 268435455 |    499,440,469.03 ns |  9,813,717.2284 ns | 15,847,324.0416 ns |    499,016,466.60 ns |
               ParallelForPartitioned | 268435455 |    522,902,405.28 ns |  8,136,236.6312 ns |  7,610,640.0523 ns |    526,002,945.25 ns |
                              LinqZip | 268435455 |  7,692,469,930.24 ns |  4,357,646.2551 ns |  4,076,144.6141 ns |  7,691,519,925.03 ns |
              LinqSelectWithElementAt | 268435455 | 16,920,958,798.44 ns | 56,580,728.5489 ns | 50,157,337.1850 ns | 16,934,597,929.41 ns |
      ParallelLinqSelectWithElementAt | 268435455 |    839,223,675.01 ns |  4,620,751.9736 ns |  4,322,253.8424 ns |    838,330,135.21 ns |
         LinqSelectWithDirectAccessor | 268435455 |  5,731,424,221.72 ns |  8,716,127.5510 ns |  7,278,360.5614 ns |  5,729,374,358.52 ns |
 ParallelLinqSelectWithDirectAccessor | 268435455 |    560,375,987.33 ns | 11,166,472.5276 ns | 12,859,325.2178 ns |    559,751,216.03 ns |
                              SimdFor | 268435455 |    616,498,043.94 ns |  5,037,350.2960 ns |  4,711,940.1338 ns |    615,940,024.10 ns |
                      ParallelSimdFor | 268435455 |    323,462,091.12 ns |  5,100,266.2512 ns |  4,770,791.7515 ns |    322,215,627.65 ns |
                      
```
