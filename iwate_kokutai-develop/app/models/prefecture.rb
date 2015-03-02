class Prefecture < ActiveRecord::Base
  def self.calc_point id
    prefecture = Prefecture.find_by(id: id)
    prefecture.point = prefecture.point + 1
    prefecture.save!
  end
end
