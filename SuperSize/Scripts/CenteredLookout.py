primary = get_screens()[0].Bounds
center = point(primary.X + primary.Width / 2, primary.Y + primary.Height / 2)

all_bounds = get_all_screen_bounds()
d_top    = abs(center.Y - all_bounds.Top)
d_right  = abs(center.X - all_bounds.Right)
d_bottom = abs(center.Y - all_bounds.Bottom)
d_left   = abs(center.X - all_bounds.Left)

dw = min(d_left, d_right)
dh = min(d_top, d_bottom)

set_size(rectangle(center.X - dw,
                   center.Y - dh,
                   2 * dw,
                   2 * dh))
