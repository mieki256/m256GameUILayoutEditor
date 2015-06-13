#!ruby -Ks
# -*- mode: ruby; Encoding: sjis; coding: sjis -*-
# Last updated: <2015/06/13 10:42:40 +0900>
#
# Ruby + DXRuby を使ってレイアウトを再現してみるテスト

require 'dxruby'
require 'yaml'

o = YAML.load_file("layout1.yml")

Window.resize(o[:canvas_w], o[:canvas_h])
sprs = []
o[:objs].each do |d|
  img = Image.load(d[:id])
  spr = Sprite.new(d[:x], d[:y], img)
  sprs.push(spr)
end

Window.loop do
  break if Input.keyPush?(K_ESCAPE)
  Sprite.draw(sprs)
end


