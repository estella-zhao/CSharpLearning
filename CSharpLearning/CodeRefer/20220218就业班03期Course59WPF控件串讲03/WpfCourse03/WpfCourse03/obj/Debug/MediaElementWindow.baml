   M S B A M L   `   `   `  ����F  BWpfCourse03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfCourse03WpfCourse03  5   	   $    WpfCourse03.MediaElementWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfCourse03     5   	   -   5          � Title$  MediaElementWindow��5   	   $	��450��6$   $	��800��61   .��5	      � .+�5
   
   �� .+�5      �� 
��� ���$��3q�6+   $��Center=�6?   $	��Top=�6\   $	��500��6t   $	��300��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Green��6'   ._�5      r� -   5        $��me��5       r� LoadedBehavior$ Manual=�6)    r� 
SpeedRatio$ 1Q�6A    r� Stretch$
 Fill=�6P    r� UnloadedBehavior$
 Stop=�6_    r� ScrubbingEnabled .  r� Balance$	 0.6Q�6�   	 r� Volume	 6�   �� 
 �� ElementName$
 volumeSlider�� �� Path$ Value�6  5      �� 5      $��0,10,0,0q�6    �� Orientation$ 
Horizontal=�6+   $��Center=�6D   .+�5      �� $��播放进度��6   
��� ���$��5q�6:   �� 5      -   5         ��Name$ 	posSlider��5       � Minimum$ 0Q�6,   $	��200��68    �� IsMoveToPointEnabled . $	��0,5q�6�    � Value 6D   �� $
 me��$ Position�6�   �� 5      $��音量��6   
��� ���$��20,5,0,0q�68   �� 5      -   5        $ volumeSlider��5      $ 0Q�6/   $	��150��6;    � Maximum$ 1Q�6G   $	 0.5Q�6S    . $	��0,5q�6~   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $��Bottom=�6O   $
��0,10q�6j   .+�5      �� -   5        $��btnOpen��5      $��打开��6(   $��60��65   $��25��6@   $
��10,0q�6M   6[   �� 5      -   5        $��btnPlay��5      $��播放��6(   $��60��65   $��25��6@   $
��10,0q�6L   6Z   �� 5      -   5        $��btnStop��5      $��停止��6(   $��60��65   $��25��6@   $
��10,0q�6L   6Z   �� 5      -   5        $��btnBack��5      $��快退��6(   $��60��65   $��25��6@   $
��10,0q�6L   6Z   �� 5      -	   5        $��
btnForward��5      $��快进��6+   $��60��68   $��25��6C   $
��10,0q�6O   6]   �� 5      -
   5        $��lblTime��5      $	��100��6'   $��25��63   $��0:00:00��6?   5      5      5       5!      