# IntegerAdditionBenchmark
Integer Addition Benchmark in C# - various implementations!

## Run on Core i7-7700HQ 4c/8t - Ubuntu
```
BenchmarkDotNet=v0.11.0, OS=ubuntu 16.04
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


                               Method |      Size |                 Mean |              Error |             StdDev |               Median |
------------------------------------- |---------- |---------------------:|-------------------:|-------------------:|---------------------:|
                              ForLoop |        15 |             18.06 ns |          0.3954 ns |          0.4395 ns |             17.87 ns |
                         ForLoopConst |        15 |             18.08 ns |          0.1465 ns |          0.1370 ns |             18.06 ns |
                       ForLoopReverse |        15 |             26.55 ns |          0.1283 ns |          0.1137 ns |             26.55 ns |
          ForLoopReversePostIncrement |        15 |             24.06 ns |          0.1073 ns |          0.0951 ns |             24.03 ns |
                          ParallelFor |        15 |          4,026.40 ns |         33.2026 ns |         31.0578 ns |          4,033.03 ns |
               ParallelForPartitioned |        15 |        119,215.41 ns |      2,373.7253 ns |      2,220.3839 ns |        119,293.73 ns |
                              LinqZip |        15 |            526.23 ns |          3.3317 ns |          2.7821 ns |            525.38 ns |
              LinqSelectWithElementAt |        15 |          1,169.28 ns |          6.6188 ns |          5.5270 ns |          1,169.90 ns |
      ParallelLinqSelectWithElementAt |        15 |          8,662.29 ns |        145.0481 ns |        135.6781 ns |          8,613.23 ns |
         LinqSelectWithDirectAccessor |        15 |            452.59 ns |          1.6207 ns |          1.3534 ns |            452.46 ns |
 ParallelLinqSelectWithDirectAccessor |        15 |          8,682.40 ns |         80.5681 ns |         75.3634 ns |          8,668.37 ns |
                              SimdFor |        15 |             15.16 ns |          0.0758 ns |          0.0709 ns |             15.13 ns |
                      ParallelSimdFor |        15 |        117,321.11 ns |      1,240.5766 ns |      1,099.7388 ns |        117,209.74 ns |
                              ForLoop |       255 |            166.81 ns |          1.1090 ns |          0.9831 ns |            166.95 ns |
                         ForLoopConst |       255 |            192.66 ns |          1.5993 ns |          1.4177 ns |            192.47 ns |
                       ForLoopReverse |       255 |            241.42 ns |          0.9741 ns |          0.9111 ns |            241.27 ns |
          ForLoopReversePostIncrement |       255 |            240.65 ns |          1.3509 ns |          1.1281 ns |            240.48 ns |
                          ParallelFor |       255 |          5,835.30 ns |         34.4131 ns |         30.5063 ns |          5,837.59 ns |
               ParallelForPartitioned |       255 |        117,372.64 ns |      1,298.2010 ns |      1,150.8213 ns |        117,633.47 ns |
                              LinqZip |       255 |          4,930.66 ns |         34.8243 ns |         29.0799 ns |          4,934.93 ns |
              LinqSelectWithElementAt |       255 |         15,523.12 ns |        234.9376 ns |        208.2661 ns |         15,459.78 ns |
      ParallelLinqSelectWithElementAt |       255 |         12,954.96 ns |        100.7407 ns |         89.3040 ns |         12,990.77 ns |
         LinqSelectWithDirectAccessor |       255 |          5,267.57 ns |        130.5824 ns |        368.3098 ns |          5,386.94 ns |
 ParallelLinqSelectWithDirectAccessor |       255 |         14,549.89 ns |        289.5963 ns |        797.6323 ns |         14,817.30 ns |
                              SimdFor |       255 |            117.18 ns |          0.0835 ns |          0.0781 ns |            117.17 ns |
                      ParallelSimdFor |       255 |        149,514.18 ns |      2,763.5227 ns |      2,449.7907 ns |        148,808.29 ns |
                              ForLoop |      4095 |          3,285.84 ns |          1.7879 ns |          1.5849 ns |          3,285.59 ns |
                         ForLoopConst |      4095 |          3,781.15 ns |          1.9958 ns |          1.6666 ns |          3,780.74 ns |
                       ForLoopReverse |      4095 |          4,675.61 ns |          9.8679 ns |          8.7476 ns |          4,675.45 ns |
          ForLoopReversePostIncrement |      4095 |          4,669.21 ns |          4.3158 ns |          3.8259 ns |          4,669.60 ns |
                          ParallelFor |      4095 |         20,581.99 ns |        143.8439 ns |        127.5139 ns |         20,563.44 ns |
               ParallelForPartitioned |      4095 |        151,722.47 ns |      2,109.6378 ns |      1,973.3563 ns |        151,275.28 ns |
                              LinqZip |      4095 |         93,490.44 ns |         64.3100 ns |         57.0092 ns |         93,494.05 ns |
              LinqSelectWithElementAt |      4095 |        318,844.41 ns |        284.2199 ns |        251.9536 ns |        318,868.75 ns |
      ParallelLinqSelectWithElementAt |      4095 |        122,698.16 ns |      3,740.3406 ns |     10,910.7490 ns |        126,587.01 ns |
         LinqSelectWithDirectAccessor |      4095 |         74,489.20 ns |         40.2085 ns |         33.5759 ns |         74,484.97 ns |
 ParallelLinqSelectWithDirectAccessor |      4095 |         38,253.34 ns |        732.9319 ns |      1,074.3221 ns |         38,434.57 ns |
                              SimdFor |      4095 |          1,711.98 ns |          0.7701 ns |          0.6430 ns |          1,712.07 ns |
                      ParallelSimdFor |      4095 |        151,771.99 ns |      2,913.8387 ns |      3,238.7237 ns |        150,365.35 ns |
                              ForLoop |     65535 |        132,076.08 ns |        821.2447 ns |        768.1927 ns |        132,454.47 ns |
                         ForLoopConst |     65535 |        131,983.89 ns |        105.4077 ns |         93.4412 ns |        131,974.47 ns |
                       ForLoopReverse |     65535 |        154,890.68 ns |        212.2039 ns |        198.4956 ns |        154,918.03 ns |
          ForLoopReversePostIncrement |     65535 |        156,061.50 ns |        187.2296 ns |        175.1346 ns |        156,053.57 ns |
                          ParallelFor |     65535 |        175,546.88 ns |      1,155.8079 ns |      1,081.1433 ns |        175,245.96 ns |
               ParallelForPartitioned |     65535 |        283,432.71 ns |      1,433.4026 ns |      1,340.8055 ns |        283,083.35 ns |
                              LinqZip |     65535 |      1,634,459.49 ns |      3,154.8598 ns |      2,951.0575 ns |      1,633,137.97 ns |
              LinqSelectWithElementAt |     65535 |      5,227,499.29 ns |      5,256.1889 ns |      4,916.6419 ns |      5,225,544.53 ns |
      ParallelLinqSelectWithElementAt |     65535 |      1,719,049.93 ns |     44,209.9008 ns |    129,659.9859 ns |      1,775,412.91 ns |
         LinqSelectWithDirectAccessor |     65535 |      1,324,810.98 ns |        653.8173 ns |        579.5920 ns |      1,324,792.59 ns |
 ParallelLinqSelectWithDirectAccessor |     65535 |        424,627.44 ns |      8,463.2053 ns |     22,295.4679 ns |        426,612.11 ns |
                              SimdFor |     65535 |        107,830.01 ns |        701.9820 ns |        656.6343 ns |        107,765.36 ns |
                      ParallelSimdFor |     65535 |        269,295.39 ns |      2,622.2889 ns |      2,452.8904 ns |        269,722.70 ns |
                              ForLoop |   1048575 |      2,130,495.66 ns |     20,613.0538 ns |     18,272.9335 ns |      2,129,090.92 ns |
                         ForLoopConst |   1048575 |      2,127,716.06 ns |     14,012.8247 ns |     11,701.3421 ns |      2,123,289.82 ns |
                       ForLoopReverse |   1048575 |      2,542,533.97 ns |      8,406.7735 ns |      7,020.0359 ns |      2,541,913.68 ns |
          ForLoopReversePostIncrement |   1048575 |      2,546,494.84 ns |     13,942.9599 ns |     13,042.2521 ns |      2,549,955.71 ns |
                          ParallelFor |   1048575 |      2,515,338.70 ns |     49,322.9087 ns |     48,441.6868 ns |      2,512,780.86 ns |
               ParallelForPartitioned |   1048575 |      1,142,043.93 ns |     22,599.6655 ns |     17,644.3307 ns |      1,139,945.81 ns |
                              LinqZip |   1048575 |     24,823,331.31 ns |     62,122.4832 ns |     58,109.4037 ns |     24,814,021.50 ns |
              LinqSelectWithElementAt |   1048575 |     83,569,211.46 ns |     62,051.7755 ns |     55,007.2773 ns |     83,584,071.75 ns |
      ParallelLinqSelectWithElementAt |   1048575 |     26,487,859.92 ns |    585,473.8902 ns |  1,698,565.9159 ns |     26,972,142.84 ns |
         LinqSelectWithDirectAccessor |   1048575 |     19,964,842.43 ns |     25,873.5430 ns |     24,202.1258 ns |     19,960,433.82 ns |
 ParallelLinqSelectWithDirectAccessor |   1048575 |      6,221,192.26 ns |    124,231.4518 ns |    329,444.1865 ns |      6,253,162.82 ns |
                              SimdFor |   1048575 |      1,847,350.78 ns |        613.7400 ns |        479.1678 ns |      1,847,305.27 ns |
                      ParallelSimdFor |   1048575 |      1,132,285.08 ns |      4,319.1595 ns |      3,828.8220 ns |      1,131,613.20 ns |
                              ForLoop |  16777215 |     32,201,103.37 ns |    126,968.1786 ns |    118,766.1015 ns |     32,135,791.07 ns |
                         ForLoopConst |  16777215 |     32,354,652.65 ns |    146,802.0416 ns |    137,318.7074 ns |     32,294,222.67 ns |
                       ForLoopReverse |  16777215 |     40,501,725.85 ns |     84,927.6709 ns |     75,286.1608 ns |     40,475,972.31 ns |
          ForLoopReversePostIncrement |  16777215 |     40,717,268.04 ns |    119,875.9977 ns |    106,266.9392 ns |     40,747,341.35 ns |
                          ParallelFor |  16777215 |     43,085,829.61 ns |  1,202,154.4523 ns |  3,544,579.5259 ns |     44,409,206.40 ns |
               ParallelForPartitioned |  16777215 |     14,374,428.52 ns |     80,351.1486 ns |     71,229.1934 ns |     14,403,256.49 ns |
                              LinqZip |  16777215 |    420,966,216.53 ns |  1,727,773.4408 ns |  1,616,160.1913 ns |    420,482,978.00 ns |
              LinqSelectWithElementAt |  16777215 |  1,340,436,118.47 ns |  2,679,446.4670 ns |  2,506,355.6438 ns |  1,340,421,910.00 ns |
      ParallelLinqSelectWithElementAt |  16777215 |    318,014,835.27 ns |  1,902,300.6782 ns |  1,779,413.0615 ns |    318,464,103.00 ns |
         LinqSelectWithDirectAccessor |  16777215 |    340,291,231.07 ns |    579,293.7516 ns |    541,871.6819 ns |    340,069,810.00 ns |
 ParallelLinqSelectWithDirectAccessor |  16777215 |     87,893,535.61 ns |  1,887,078.8806 ns |  5,564,094.6562 ns |     89,598,290.75 ns |
                              SimdFor |  16777215 |     28,791,832.84 ns |     55,796.2227 ns |     52,191.8163 ns |     28,797,725.14 ns |
                      ParallelSimdFor |  16777215 |     12,631,881.20 ns |    207,752.4223 ns |    194,331.7258 ns |     12,680,172.98 ns |
                              ForLoop | 268435455 |    496,433,359.40 ns |    383,452.0759 ns |    358,681.2748 ns |    496,425,852.00 ns |
                         ForLoopConst | 268435455 |    498,407,893.47 ns |    569,933.0827 ns |    533,115.7073 ns |    498,336,481.00 ns |
                       ForLoopReverse | 268435455 |    607,508,448.40 ns |  2,497,215.6603 ns |  2,335,896.8508 ns |    607,261,028.00 ns |
          ForLoopReversePostIncrement | 268435455 |    608,542,405.53 ns |  2,101,541.0148 ns |  1,965,782.5778 ns |    608,340,732.00 ns |
                          ParallelFor | 268435455 |    732,169,815.08 ns | 32,161,676.2589 ns | 94,829,428.0915 ns |    739,189,924.00 ns |
               ParallelForPartitioned | 268435455 |    182,895,732.52 ns |  3,500,239.6366 ns |  3,274,126.0092 ns |    183,651,963.75 ns |
                              LinqZip | 268435455 |  6,708,246,578.23 ns |  8,038,872.0030 ns |  6,712,821.5600 ns |  6,707,565,546.00 ns |
              LinqSelectWithElementAt | 268435455 | 21,474,334,602.53 ns | 28,551,954.1676 ns | 26,707,513.0444 ns | 21,471,038,260.00 ns |
      ParallelLinqSelectWithElementAt | 268435455 |  6,567,896,923.87 ns | 38,587,138.8773 ns | 36,094,430.1346 ns |  6,567,554,644.00 ns |
         LinqSelectWithDirectAccessor | 268435455 |  5,450,814,815.00 ns |  3,081,362.6444 ns |  2,731,547.4563 ns |  5,450,220,131.50 ns |
 ParallelLinqSelectWithDirectAccessor | 268435455 |  1,348,339,619.40 ns | 26,674,475.3560 ns | 69,802,452.7946 ns |  1,364,064,144.50 ns |
                              SimdFor | 268435455 |    433,572,883.80 ns |    216,806.0193 ns |    202,800.4653 ns |    433,563,859.00 ns |
                      ParallelSimdFor | 268435455 |    150,701,243.04 ns |  2,408,472.3904 ns |  2,135,047.8313 ns |    150,782,863.00 ns |
```


## Run on E3-1245v3 4c/8t - Windows
```
BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.165 (1803/April2018Update/Redstone4)
Intel Xeon CPU E3-1245 v3 3.40GHz, 1 CPU, 8 logical and 4 physical cores
Frequency=3318391 Hz, Resolution=301.3509 ns, Timer=TSC
.NET Core SDK=2.1.301
  [Host]     : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT


                               Method |      Size |                 Mean |              Error |             StdDev |               Median |
------------------------------------- |---------- |---------------------:|-------------------:|-------------------:|---------------------:|
                              ForLoop |        15 |             19.13 ns |          0.2492 ns |          0.2209 ns |             19.13 ns |
                         ForLoopConst |        15 |             17.81 ns |          0.0804 ns |          0.0628 ns |             17.79 ns |
                       ForLoopReverse |        15 |             23.24 ns |          0.1300 ns |          0.1216 ns |             23.29 ns |
          ForLoopReversePostIncrement |        15 |             23.12 ns |          0.0731 ns |          0.0684 ns |             23.10 ns |
                          ParallelFor |        15 |          3,410.80 ns |         19.5658 ns |         17.3445 ns |          3,413.40 ns |
               ParallelForPartitioned |        15 |          3,299.78 ns |         47.4353 ns |         44.3710 ns |          3,308.41 ns |
                              LinqZip |        15 |            550.30 ns |          1.2596 ns |          1.1782 ns |            550.14 ns |
              LinqSelectWithElementAt |        15 |            937.48 ns |          7.7097 ns |          6.4379 ns |            934.97 ns |
      ParallelLinqSelectWithElementAt |        15 |          8,246.46 ns |         23.1778 ns |         21.6805 ns |          8,249.05 ns |
         LinqSelectWithDirectAccessor |        15 |            435.55 ns |          0.6538 ns |          0.6116 ns |            435.34 ns |
 ParallelLinqSelectWithDirectAccessor |        15 |          7,934.13 ns |         25.5212 ns |         23.8725 ns |          7,930.42 ns |
                              SimdFor |        15 |             15.38 ns |          0.0410 ns |          0.0384 ns |             15.38 ns |
                      ParallelSimdFor |        15 |          2,749.04 ns |         53.8606 ns |         55.3109 ns |          2,767.60 ns |
                              ForLoop |       255 |            184.89 ns |          0.3968 ns |          0.3711 ns |            184.85 ns |
                         ForLoopConst |       255 |            183.70 ns |          0.5134 ns |          0.4802 ns |            183.44 ns |
                       ForLoopReverse |       255 |            243.97 ns |          1.2648 ns |          1.0562 ns |            243.63 ns |
          ForLoopReversePostIncrement |       255 |            243.35 ns |          0.6614 ns |          0.5863 ns |            243.23 ns |
                          ParallelFor |       255 |          5,269.53 ns |          9.8451 ns |          9.2091 ns |          5,268.90 ns |
               ParallelForPartitioned |       255 |          3,670.98 ns |         25.8646 ns |         24.1937 ns |          3,677.12 ns |
                              LinqZip |       255 |          5,823.43 ns |         18.9817 ns |         15.8506 ns |          5,823.85 ns |
              LinqSelectWithElementAt |       255 |         12,274.29 ns |         35.1186 ns |         31.1317 ns |         12,271.12 ns |
      ParallelLinqSelectWithElementAt |       255 |         11,272.10 ns |         79.1851 ns |         70.1955 ns |         11,250.77 ns |
         LinqSelectWithDirectAccessor |       255 |          4,196.09 ns |          8.4741 ns |          7.9266 ns |          4,194.84 ns |
 ParallelLinqSelectWithDirectAccessor |       255 |          8,749.98 ns |         23.0864 ns |         21.5950 ns |          8,746.11 ns |
                              SimdFor |       255 |             89.41 ns |          0.1936 ns |          0.1716 ns |             89.38 ns |
                      ParallelSimdFor |       255 |          2,930.07 ns |         43.4862 ns |         38.5494 ns |          2,932.01 ns |
                              ForLoop |      4095 |          2,649.57 ns |          5.1673 ns |          4.5807 ns |          2,648.75 ns |
                         ForLoopConst |      4095 |          2,659.70 ns |         10.2836 ns |          9.6193 ns |          2,661.08 ns |
                       ForLoopReverse |      4095 |          3,585.30 ns |          6.8184 ns |          6.0444 ns |          3,585.58 ns |
          ForLoopReversePostIncrement |      4095 |          3,588.21 ns |          6.1620 ns |          5.1455 ns |          3,588.87 ns |
                          ParallelFor |      4095 |         14,090.79 ns |         86.0116 ns |         71.8236 ns |         14,058.36 ns |
               ParallelForPartitioned |      4095 |          8,158.18 ns |         42.1712 ns |         39.4470 ns |          8,153.89 ns |
                              LinqZip |      4095 |         86,130.34 ns |        323.8169 ns |        302.8985 ns |         86,199.56 ns |
              LinqSelectWithElementAt |      4095 |        188,802.73 ns |        490.9734 ns |        435.2351 ns |        188,768.16 ns |
      ParallelLinqSelectWithElementAt |      4095 |         57,559.40 ns |        340.3634 ns |        301.7233 ns |         57,538.45 ns |
         LinqSelectWithDirectAccessor |      4095 |         61,044.05 ns |        107.4582 ns |        100.5165 ns |         61,046.27 ns |
 ParallelLinqSelectWithDirectAccessor |      4095 |         21,668.37 ns |        333.5762 ns |        278.5512 ns |         21,638.14 ns |
                              SimdFor |      4095 |          1,553.68 ns |          2.7090 ns |          2.1150 ns |          1,553.81 ns |
                      ParallelSimdFor |      4095 |          5,400.62 ns |         43.6784 ns |         40.8568 ns |          5,402.36 ns |
                              ForLoop |     65535 |        101,820.51 ns |        351.6086 ns |        328.8949 ns |        101,761.49 ns |
                         ForLoopConst |     65535 |        101,911.33 ns |        332.1021 ns |        310.6484 ns |        101,883.04 ns |
                       ForLoopReverse |     65535 |        113,966.88 ns |        243.9107 ns |        228.1542 ns |        113,940.18 ns |
          ForLoopReversePostIncrement |     65535 |        115,285.32 ns |        211.4521 ns |        187.4467 ns |        115,293.07 ns |
                          ParallelFor |     65535 |        140,249.29 ns |        612.8017 ns |        478.4352 ns |        140,329.89 ns |
               ParallelForPartitioned |     65535 |         92,002.57 ns |        566.2464 ns |        529.6671 ns |         92,020.00 ns |
                              LinqZip |     65535 |      1,459,620.15 ns |      2,416.5857 ns |      2,260.4756 ns |      1,458,792.22 ns |
              LinqSelectWithElementAt |     65535 |      3,116,189.86 ns |      7,883.2835 ns |      7,374.0276 ns |      3,113,976.27 ns |
      ParallelLinqSelectWithElementAt |     65535 |        829,986.58 ns |      1,677.0144 ns |      1,486.6294 ns |        829,989.67 ns |
         LinqSelectWithDirectAccessor |     65535 |      1,074,939.04 ns |      2,276.9198 ns |      2,129.8319 ns |      1,074,676.46 ns |
 ParallelLinqSelectWithDirectAccessor |     65535 |        261,467.76 ns |      1,090.1431 ns |        851.1119 ns |        261,545.90 ns |
                              SimdFor |     65535 |         96,087.61 ns |        189.3526 ns |        147.8340 ns |         96,101.54 ns |
                      ParallelSimdFor |     65535 |         70,452.45 ns |        128.4495 ns |        113.8671 ns |         70,462.78 ns |
                              ForLoop |   1048575 |      1,861,302.74 ns |     73,392.5244 ns |    216,399.5141 ns |      1,986,345.58 ns |
                         ForLoopConst |   1048575 |      1,597,027.05 ns |     79,772.6272 ns |    235,211.3911 ns |      1,547,160.77 ns |
                       ForLoopReverse |   1048575 |      1,811,131.47 ns |     88,444.8506 ns |    260,781.6376 ns |      1,769,653.29 ns |
          ForLoopReversePostIncrement |   1048575 |      1,860,560.57 ns |     76,980.7105 ns |    226,979.3619 ns |      1,888,392.46 ns |
                          ParallelFor |   1048575 |      2,084,613.49 ns |     40,910.9310 ns |     42,012.5101 ns |      2,073,564.46 ns |
               ParallelForPartitioned |   1048575 |      1,184,712.62 ns |     14,084.1572 ns |     13,174.3281 ns |      1,182,503.53 ns |
                              LinqZip |   1048575 |     22,955,255.90 ns |     42,460.6341 ns |     39,717.6996 ns |     22,963,644.13 ns |
              LinqSelectWithElementAt |   1048575 |     50,413,576.94 ns |    100,915.5352 ns |     94,396.4450 ns |     50,428,114.11 ns |
      ParallelLinqSelectWithElementAt |   1048575 |     12,885,266.56 ns |     90,329.3867 ns |     84,494.1561 ns |     12,880,535.35 ns |
         LinqSelectWithDirectAccessor |   1048575 |     16,778,607.84 ns |     26,303.1424 ns |     24,603.9734 ns |     16,778,295.19 ns |
 ParallelLinqSelectWithDirectAccessor |   1048575 |      3,884,843.97 ns |     20,562.9174 ns |     19,234.5638 ns |      3,876,670.37 ns |
                              SimdFor |   1048575 |      1,754,978.48 ns |     78,185.6534 ns |    230,532.1631 ns |      1,810,397.81 ns |
                      ParallelSimdFor |   1048575 |      1,210,840.97 ns |     11,829.8189 ns |     11,065.6188 ns |      1,215,083.03 ns |
                              ForLoop |  16777215 |     33,742,774.99 ns |    296,145.0726 ns |    277,014.2577 ns |     33,708,960.91 ns |
                         ForLoopConst |  16777215 |     33,696,092.21 ns |    110,292.1476 ns |     92,098.9296 ns |     33,684,436.60 ns |
                       ForLoopReverse |  16777215 |     35,482,720.58 ns |    238,436.2242 ns |    223,033.3703 ns |     35,445,307.87 ns |
          ForLoopReversePostIncrement |  16777215 |     35,618,038.73 ns |    293,848.1814 ns |    274,865.7444 ns |     35,521,661.70 ns |
                          ParallelFor |  16777215 |     27,920,829.57 ns |    546,040.9915 ns |    747,427.0726 ns |     27,945,687.76 ns |
               ParallelForPartitioned |  16777215 |     18,844,281.82 ns |    362,763.4606 ns |    356,282.1900 ns |     18,821,216.12 ns |
                              LinqZip |  16777215 |    375,636,867.39 ns |    934,891.6519 ns |    828,757.0170 ns |    375,673,180.17 ns |
              LinqSelectWithElementAt |  16777215 |    800,435,592.63 ns |  1,879,979.9216 ns |  1,758,534.2140 ns |    799,920,804.99 ns |
      ParallelLinqSelectWithElementAt |  16777215 |    188,792,299.24 ns |  2,534,735.7723 ns |  2,246,977.0197 ns |    187,507,037.80 ns |
         LinqSelectWithDirectAccessor |  16777215 |    277,793,203.59 ns |  1,685,487.2340 ns |  1,576,605.6510 ns |    277,261,028.01 ns |
 ParallelLinqSelectWithDirectAccessor |  16777215 |     56,619,315.41 ns |  1,131,381.9846 ns |  1,693,399.2830 ns |     56,282,487.51 ns |
                              SimdFor |  16777215 |     33,413,587.46 ns |    147,774.4267 ns |    138,228.2770 ns |     33,403,114.27 ns |
                      ParallelSimdFor |  16777215 |     19,561,267.88 ns |    151,337.1461 ns |    134,156.4250 ns |     19,548,908.45 ns |
                              ForLoop | 268435455 |    485,019,537.08 ns |  2,420,226.8519 ns |  2,263,881.4785 ns |    484,441,405.49 ns |
                         ForLoopConst | 268435455 |    490,739,136.33 ns |  3,130,536.5372 ns |  2,928,305.5343 ns |    489,410,982.61 ns |
                       ForLoopReverse | 268435455 |    533,137,194.10 ns |  5,284,012.4182 ns |  4,942,668.0135 ns |    531,356,009.58 ns |
          ForLoopReversePostIncrement | 268435455 |    530,558,678.24 ns |  2,242,986.7978 ns |  1,988,349.1783 ns |    530,058,392.76 ns |
                          ParallelFor | 268435455 |    505,360,257.43 ns | 10,894,497.5780 ns | 32,122,671.9140 ns |    504,020,623.25 ns |
               ParallelForPartitioned | 268435455 |    239,141,137.98 ns |  2,166,675.3083 ns |  2,026,709.2305 ns |    238,745,825.92 ns |
                              LinqZip | 268435455 |  6,038,249,038.97 ns |  7,463,351.9310 ns |  6,981,223.3475 ns |  6,036,464,961.48 ns |
              LinqSelectWithElementAt | 268435455 | 12,827,657,208.20 ns | 16,779,201.3082 ns | 14,011,391.6804 ns | 12,820,581,420.33 ns |
      ParallelLinqSelectWithElementAt | 268435455 |  3,006,171,002.76 ns | 31,020,630.5766 ns | 29,016,714.2643 ns |  2,991,639,924.29 ns |
         LinqSelectWithDirectAccessor | 268435455 |  4,475,717,663.86 ns | 13,952,749.9886 ns | 12,368,748.2255 ns |  4,474,417,571.65 ns |
 ParallelLinqSelectWithDirectAccessor | 268435455 |    802,544,411.99 ns |  2,958,474.7046 ns |  2,470,460.1311 ns |    802,666,714.08 ns |
                              SimdFor | 268435455 |    479,235,589.38 ns |  3,128,548.6467 ns |  2,926,446.0605 ns |    478,146,788.61 ns |
                      ParallelSimdFor | 268435455 |    253,456,569.77 ns |  1,658,087.1862 ns |  1,469,850.9584 ns |    253,168,528.56 ns |
```

## Run on E5-2650 v3 2x 10c/20t

```
BenchmarkDotNet=v0.11.0, OS=ubuntu 16.04
Intel Xeon CPU E3-1245 v3 3.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


                               Method |      Size |                 Mean |              Error |             StdDev |
------------------------------------- |---------- |---------------------:|-------------------:|-------------------:|
                              ForLoop |        15 |             20.24 ns |          0.2281 ns |          0.2133 ns |
                         ForLoopConst |        15 |             19.79 ns |          0.0608 ns |          0.0569 ns |
                       ForLoopReverse |        15 |             25.07 ns |          0.0588 ns |          0.0491 ns |
          ForLoopReversePostIncrement |        15 |             25.14 ns |          0.0888 ns |          0.0787 ns |
                          ParallelFor |        15 |          4,016.79 ns |         76.0019 ns |         71.0922 ns |
               ParallelForPartitioned |        15 |        112,264.21 ns |      1,760.5324 ns |      1,646.8029 ns |
                              LinqZip |        15 |            562.58 ns |          2.0333 ns |          1.9020 ns |
              LinqSelectWithElementAt |        15 |          1,145.72 ns |          4.6369 ns |          4.1105 ns |
      ParallelLinqSelectWithElementAt |        15 |          9,684.14 ns |         95.2786 ns |         89.1237 ns |
         LinqSelectWithDirectAccessor |        15 |            455.36 ns |          1.0727 ns |          0.8375 ns |
 ParallelLinqSelectWithDirectAccessor |        15 |          9,592.27 ns |        159.0780 ns |        141.0185 ns |
                              SimdFor |        15 |             19.21 ns |          0.0897 ns |          0.0839 ns |
                      ParallelSimdFor |        15 |        111,964.53 ns |      2,103.9617 ns |      1,968.0469 ns |
                              ForLoop |       255 |            185.70 ns |          0.2962 ns |          0.2626 ns |
                         ForLoopConst |       255 |            185.14 ns |          0.7557 ns |          0.7069 ns |
                       ForLoopReverse |       255 |            245.14 ns |          0.5753 ns |          0.5381 ns |
          ForLoopReversePostIncrement |       255 |            245.69 ns |          0.7350 ns |          0.6875 ns |
                          ParallelFor |       255 |          5,737.04 ns |         65.1209 ns |         60.9141 ns |
               ParallelForPartitioned |       255 |        112,319.90 ns |      1,690.7681 ns |      1,498.8217 ns |
                              LinqZip |       255 |          5,571.51 ns |          7.7894 ns |          6.5045 ns |
              LinqSelectWithElementAt |       255 |         15,221.18 ns |         50.4354 ns |         42.1159 ns |
      ParallelLinqSelectWithElementAt |       255 |         13,915.61 ns |         57.9916 ns |         54.2454 ns |
         LinqSelectWithDirectAccessor |       255 |          4,277.68 ns |         11.3002 ns |         10.0173 ns |
 ParallelLinqSelectWithDirectAccessor |       255 |         11,234.65 ns |        215.5106 ns |        211.6602 ns |
                              SimdFor |       255 |            104.04 ns |          0.1136 ns |          0.0948 ns |
                      ParallelSimdFor |       255 |        111,726.88 ns |      2,130.4953 ns |      1,992.8664 ns |
                              ForLoop |      4095 |          2,635.33 ns |          3.7127 ns |          3.4729 ns |
                         ForLoopConst |      4095 |          2,595.39 ns |          6.5593 ns |          5.8146 ns |
                       ForLoopReverse |      4095 |          3,523.43 ns |          8.5230 ns |          7.5554 ns |
          ForLoopReversePostIncrement |      4095 |          3,541.43 ns |          8.4817 ns |          7.0826 ns |
                          ParallelFor |      4095 |         16,145.92 ns |        112.1468 ns |        104.9021 ns |
               ParallelForPartitioned |      4095 |        122,681.70 ns |      1,184.5380 ns |      1,108.0175 ns |
                              LinqZip |      4095 |         81,397.59 ns |        290.4108 ns |        257.4416 ns |
              LinqSelectWithElementAt |      4095 |        235,671.82 ns |        586.8901 ns |        490.0797 ns |
      ParallelLinqSelectWithElementAt |      4095 |         82,259.35 ns |        469.7772 ns |        439.4299 ns |
         LinqSelectWithDirectAccessor |      4095 |         61,527.25 ns |        290.9111 ns |        227.1243 ns |
 ParallelLinqSelectWithDirectAccessor |      4095 |         24,762.44 ns |        213.8044 ns |        199.9928 ns |
                              SimdFor |      4095 |          1,612.58 ns |          3.7032 ns |          3.4640 ns |
                      ParallelSimdFor |      4095 |        115,137.46 ns |      1,497.8112 ns |      1,401.0534 ns |
                              ForLoop |     65535 |         96,128.12 ns |        225.6516 ns |        211.0746 ns |
                         ForLoopConst |     65535 |         95,708.46 ns |        248.3003 ns |        220.1118 ns |
                       ForLoopReverse |     65535 |        111,418.78 ns |        198.3814 ns |        185.5661 ns |
          ForLoopReversePostIncrement |     65535 |        111,471.89 ns |        210.3220 ns |        186.4450 ns |
                          ParallelFor |     65535 |        141,253.43 ns |        870.0209 ns |        813.8180 ns |
               ParallelForPartitioned |     65535 |        228,912.86 ns |      1,481.3508 ns |      1,385.6563 ns |
                              LinqZip |     65535 |      1,382,107.13 ns |      7,045.3509 ns |      6,590.2250 ns |
              LinqSelectWithElementAt |     65535 |      3,869,384.99 ns |      9,846.7776 ns |      8,222.5045 ns |
      ParallelLinqSelectWithElementAt |     65535 |      1,163,529.60 ns |      7,935.7902 ns |      7,423.1423 ns |
         LinqSelectWithDirectAccessor |     65535 |      1,070,280.53 ns |      1,860.2144 ns |      1,740.0456 ns |
 ParallelLinqSelectWithDirectAccessor |     65535 |        273,900.25 ns |      3,003.3337 ns |      2,662.3769 ns |
                              SimdFor |     65535 |         77,186.91 ns |         89.1092 ns |         78.9930 ns |
                      ParallelSimdFor |     65535 |        205,694.16 ns |      2,109.4173 ns |      1,973.1500 ns |
                              ForLoop |   1048575 |      1,770,997.51 ns |     10,476.5035 ns |      9,799.7270 ns |
                         ForLoopConst |   1048575 |      1,808,634.53 ns |     35,247.5817 ns |     32,970.6066 ns |
                       ForLoopReverse |   1048575 |      2,069,944.54 ns |     30,892.7669 ns |     28,897.1106 ns |
          ForLoopReversePostIncrement |   1048575 |      2,032,285.95 ns |     20,979.6165 ns |     19,624.3444 ns |
                          ParallelFor |   1048575 |      2,117,238.64 ns |     40,382.5327 ns |     37,773.8425 ns |
               ParallelForPartitioned |   1048575 |      1,108,562.00 ns |     11,309.0556 ns |     10,578.4966 ns |
                              LinqZip |   1048575 |     21,838,844.18 ns |     99,188.6347 ns |     92,781.1014 ns |
              LinqSelectWithElementAt |   1048575 |     61,937,275.28 ns |    253,984.7669 ns |    225,150.8582 ns |
      ParallelLinqSelectWithElementAt |   1048575 |     17,713,225.69 ns |    185,406.3894 ns |    173,429.2348 ns |
         LinqSelectWithDirectAccessor |   1048575 |     16,631,467.67 ns |     18,370.3920 ns |     17,183.6744 ns |
 ParallelLinqSelectWithDirectAccessor |   1048575 |      4,092,425.59 ns |     36,337.9617 ns |     33,990.5486 ns |
                              SimdFor |   1048575 |      1,694,037.36 ns |     33,311.9949 ns |     60,912.8664 ns |
                      ParallelSimdFor |   1048575 |      1,123,425.46 ns |     14,787.7832 ns |     13,832.5003 ns |
                              ForLoop |  16777215 |     27,330,151.13 ns |    114,439.7730 ns |    107,047.0243 ns |
                         ForLoopConst |  16777215 |     27,175,910.76 ns |    174,385.9331 ns |    163,120.6941 ns |
                       ForLoopReverse |  16777215 |     31,481,119.96 ns |    170,892.3076 ns |    159,852.7550 ns |
          ForLoopReversePostIncrement |  16777215 |     31,522,630.19 ns |    218,488.8682 ns |    204,374.6030 ns |
                          ParallelFor |  16777215 |     30,105,705.07 ns |    428,924.3207 ns |    401,216.0366 ns |
               ParallelForPartitioned |  16777215 |     13,437,355.34 ns |     72,556.8685 ns |     67,869.7332 ns |
                              LinqZip |  16777215 |    360,915,602.80 ns |  2,069,287.8133 ns |  1,935,612.9161 ns |
              LinqSelectWithElementAt |  16777215 |    989,583,073.93 ns |  4,443,184.7179 ns |  4,156,157.3375 ns |
      ParallelLinqSelectWithElementAt |  16777215 |    267,552,927.43 ns |    669,166.6362 ns |    625,938.8258 ns |
         LinqSelectWithDirectAccessor |  16777215 |    278,020,636.67 ns |    460,677.8266 ns |    430,918.2829 ns |
 ParallelLinqSelectWithDirectAccessor |  16777215 |     57,282,765.53 ns |    602,776.6788 ns |    563,837.6245 ns |
                              SimdFor |  16777215 |     25,734,052.52 ns |     67,809.2351 ns |     63,428.7944 ns |
                      ParallelSimdFor |  16777215 |     13,504,157.14 ns |    187,947.7012 ns |    175,806.3792 ns |
                              ForLoop | 268435455 |    400,630,099.27 ns |    664,379.7301 ns |    621,461.1513 ns |
                         ForLoopConst | 268435455 |    401,047,473.33 ns |  3,025,618.8110 ns |  2,830,165.4376 ns |
                       ForLoopReverse | 268435455 |    456,732,086.13 ns |  1,065,678.6493 ns |    996,836.3727 ns |
          ForLoopReversePostIncrement | 268435455 |    455,059,304.60 ns |  1,041,769.9657 ns |    974,472.1775 ns |
                          ParallelFor | 268435455 |    465,941,493.69 ns | 10,666,619.4643 ns | 31,450,768.1541 ns |
               ParallelForPartitioned | 268435455 |    164,576,803.25 ns |    950,976.5722 ns |    889,543.9891 ns |
                              LinqZip | 268435455 |  5,714,986,887.47 ns | 12,674,167.4403 ns | 11,855,422.9336 ns |
              LinqSelectWithElementAt | 268435455 | 15,820,091,500.07 ns | 40,949,686.2773 ns | 38,304,358.2234 ns |
      ParallelLinqSelectWithElementAt | 268435455 |  4,244,448,797.87 ns | 11,600,925.6616 ns | 10,851,512.0056 ns |
         LinqSelectWithDirectAccessor | 268435455 |  4,446,482,520.79 ns |  5,725,485.2033 ns |  5,075,493.0037 ns |
 ParallelLinqSelectWithDirectAccessor | 268435455 |    868,380,782.00 ns |  4,880,416.7053 ns |  4,326,361.8650 ns |
                              SimdFor | 268435455 |    375,172,697.53 ns |  2,636,174.5228 ns |  2,465,879.0443 ns |
                      ParallelSimdFor | 268435455 |    164,404,366.30 ns |  2,145,389.9528 ns |  2,006,798.8977 ns |

```

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
