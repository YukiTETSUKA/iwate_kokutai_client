class AddCommentsToPrefecture < ActiveRecord::Migration
  def change
    add_column :comments, :prefecture_id, :integer
  end
end
