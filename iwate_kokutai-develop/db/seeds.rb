# This file should contain all the record creation needed to seed the database with its default values.
# The data can then be loaded with the rake db:seed (or created alongside the db with db:setup).
#
# Examples:
#
#   cities = City.create([{ name: 'Chicago' }, { name: 'Copenhagen' }])
#   Mayor.create(name: 'Emanuel', city: cities.first)
Prefecture.delete_all
Prefecture.create([
  {id:  1, name: '北海道'  , point: 0},
  {id:  2, name: '青森県'  , point: 0},
  {id:  3, name: '岩手県'  , point: 0},
  {id:  4, name: '宮城県'  , point: 0},
  {id:  5, name: '秋田県'  , point: 0},
  {id:  6, name: '山形県'  , point: 0},
  {id:  7, name: '福島県'  , point: 0},
  {id:  8, name: '茨城県'  , point: 0},
  {id:  9, name: '栃木県'  , point: 0},
  {id: 10, name: '群馬県'  , point: 0},
  {id: 11, name: '埼玉県'  , point: 0},
  {id: 12, name: '千葉県'  , point: 0},
  {id: 13, name: '東京都'  , point: 0},
  {id: 14, name: '神奈川県', point: 0},
  {id: 15, name: '新潟県'  , point: 0},
  {id: 16, name: '富山県'  , point: 0},
  {id: 17, name: '石川県'  , point: 0},
  {id: 18, name: '福井県'  , point: 0},
  {id: 19, name: '山梨県'  , point: 0},
  {id: 20, name: '長野県'  , point: 0},
  {id: 21, name: '岐阜県'  , point: 0},
  {id: 22, name: '静岡県'  , point: 0},
  {id: 23, name: '愛知県'  , point: 0},
  {id: 24, name: '三重県'  , point: 0},
  {id: 25, name: '滋賀県'  , point: 0},
  {id: 26, name: '京都府'  , point: 0},
  {id: 27, name: '大阪府'  , point: 0},
  {id: 28, name: '兵庫県'  , point: 0},
  {id: 29, name: '奈良県'  , point: 0},
  {id: 30, name: '和歌山県', point: 0},
  {id: 31, name: '鳥取県'  , point: 0},
  {id: 32, name: '島根県'  , point: 0},
  {id: 33, name: '岡山県'  , point: 0},
  {id: 34, name: '広島県'  , point: 0},
  {id: 35, name: '山口県'  , point: 0},
  {id: 36, name: '徳島県'  , point: 0},
  {id: 37, name: '香川県'  , point: 0},
  {id: 38, name: '愛媛県'  , point: 0},
  {id: 39, name: '高知県'  , point: 0},
  {id: 40, name: '福岡県'  , point: 0},
  {id: 41, name: '佐賀県'  , point: 0},
  {id: 42, name: '長崎県'  , point: 0},
  {id: 43, name: '熊本県'  , point: 0},
  {id: 44, name: '大分県'  , point: 0},
  {id: 45, name: '宮崎県'  , point: 0},
  {id: 46, name: '鹿児島県', point: 0},
  {id: 47, name: '沖縄県'  , point: 0},
])

Comment.delete_all
Comment.create([
  {comment: 'ほげほげ', prefecture_id: 2},
  {comment: 'ふがふが', prefecture_id: 2},
  {comment: 'ぴよぴよ', prefecture_id: 1}
])
