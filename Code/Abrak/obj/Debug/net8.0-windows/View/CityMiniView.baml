   M S B A M L   `   `   `  ����@  <Abrak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Abrak.ConvertersAbrak.Converters  5          Abrak.View.CityMiniView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      0localclr-namespace:Abrak.Converters     5      $	��150��5      $	��800��6     � 	Resources  5      -   'Abrak.Converters.FavoriteColorConverter   FavoriteColorConverter<   6Abrak.Converters.WeatherConditionToBackgroundConverter ) %WeatherConditionToBackgroundConverter �� 
TargetType �� Property �� Value��%&  &	        &	      '�� &       5   
   6'     5	   
   66   �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ Center=�64   �� 5       � ��$ 15q�6'   �� 5       � ��$ 17(�6)   �� 5       � ��$
 Bold"�6+   5      5      .��5      � $��Stretch=�5      $
��0,10q�5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   ��5    
   �� 5!       �� Opacity$	 0.4Q�5"       �� ImageSource 5!      �� *City.Condition+ �� 	Converter# [ 5"      .+�5%   
   �� $��0��6   ��6$   �� *	City.Name+�� 5&   
   $��1��6   ��6%   �� *City.Country+�� 5'   
   $��2��6   ��6%   �� *City.TemperatureC+ �� StringFormat$ {0}°C���� 5(   
   $��3��6   ��6%   �� *City.Condition+�� 5+   
   $��4��5,      $	��★��5-      $��20(�5.      $��40��5/      $��40��6   $��5q�50      $��10q�51      
������ $��0q�55      	 � Cursor$
	 Hand��56      ��52      �� *ToggleFavoriteCommand+��54      �� *
IsFavorite+# [  56      57      59      