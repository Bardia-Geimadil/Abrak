   M S B A M L   `   `   `  ����@  <Abrak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Abrak.View
Abrak.View  5          Abrak.View.AboutUs   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Abrak.View     5      .��5	      � 
������   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   .+�5      �� -   5         ��Name$ DeveloperTitle��5      $��	Developer��5      
�������$��Center=�5      $��25(�5      $��chilanka)�5       J� Opacity$ 0Q�5      z�5      T� 5      -   5        DeveloperTitleTransform�� T� X$
 -500Q�5   J   5      �� 5       -   5         ��Name$ DeveloperImage��5       $'��!../Resources/Images/developer.jpg��5!      $	��300��5"      $	��300��5#      $��20q�5$      $ 0Q�5%      z�5&      T� 5'      -   5        DeveloperImageTransform�� T� Y$	 500Q�5'   J   5)      �� 5,      -   5        $ DeveloperNameText��5,      
�������$��Center=�5/      $��40(�50      $��chilanka)�51      $ 0Q�52      ��5-      �� *DeveloperName+z�53      T� 54      -   5        DeveloperNameTransform��$	 500Q�54   I   56      �� 59      -   5        $ DeveloperEmailText��59      
�������$��Center=�5<      $��chilanka)�5=      $��30q�5>      $ 0Q�5?      ��5:      �� *DeveloperEmail+z�5@      T� 5A      -   5        DeveloperEmailTransform��$
 -500Q�5A   J   5C      5D      5E       � Triggers 5H      :� 5I   
    :� RoutedEvent$ Loaded��6   .[�5J      �� .��5K      �� .��5M      W�  �� 
TargetName$ DeveloperTitle��6&   	 �� TargetProperty$	 Opacity�5N   &   
 W� From
 05O   &   	 W� To 16/    g� Duration$ 0:0:0.5D�66   W� 5P      $ DeveloperTitleTransform��6&   $	 X�5Q   &   
 -5005R   &    062   $ 0:0:0.5D�69   W� 5U      $ DeveloperImage��6&   $	 Opacity�5V   &   
 05W   &    16/   $ 0:0:0.5D�66    g� 	BeginTime 0:0:0.55X   &   W� 5Y      $ DeveloperImageTransform��6&   $	 Y�5Z   &   
 5005[   &    061   $ 0:0:0.5D�68    0:0:0.55\   &   W� 5_      $ DeveloperNameText��6&   $	 Opacity�5`   &   
 05a   &    16/   $ 0:0:0.5D�66   	 0:0:15b   &   W� 5c      $ DeveloperNameTransform��6&   $	 X�5d   &   
 5005e   &    061   $ 0:0:0.5D�68   	 0:0:15f   &   W� 5i      $ DeveloperEmailText��6&   $	 Opacity�5j   &   
 05k   &    16/   $ 0:0:0.5D�66    0:0:1.55l   &   W� 5m      $ DeveloperEmailTransform��6&   $	 Y�5n   &   
 -5005o   &    062   $ 0:0:0.5D�69    0:0:1.55p   &   5q      5r      5s      5u      